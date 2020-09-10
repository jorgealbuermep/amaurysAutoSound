using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace AmaurysAutoSong
{
    public partial class Reportes : Form
    {
        Conexion conn = new Conexion();
        public Reportes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        public void generarReporte()
        {
            if (cbtipo.Text == "Compras")
            {

                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("select idcabeceracompra,numerocompra,proveedor,subtotal,itbis,total, fechacrea,estado from cabeceracompra where fechacrea between @fechainicia and  @fechafin", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fechainicia", dtFechainicia.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@fechafin", dtfechafin.Value.ToShortDateString());

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable tbl = new System.Data.DataTable();
                da.Fill(tbl);
                dgvcabecera.DataSource = tbl;
                conn.cerrarConexion();
            }
            else if (cbtipo.Text == "Ventas")
            {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("select idcabeceraventa,fechacrea,numerofactura,cliente,numerocomprobante,subtotal,itbis,total from cabeceraventas where fechacrea between @fechainicia and  @fechafin", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fechainicia", dtFechainicia.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@fechafin", dtfechafin.Value.ToShortDateString());

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable tbl = new System.Data.DataTable();
                da.Fill(tbl);
                dgvcabecera.DataSource = tbl;
                conn.cerrarConexion();

            }
        }
        public void mostrardetallesCompras()
        {



            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select producto,cantidad from detallecompras where idcabeceracompra='" + dgvcabecera.CurrentRow.Cells[0].Value.ToString() + "' ", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            // cmd.Parameters.AddWithValue("@idcabeceracompra", txtnumerocompra.Text);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            dgvdetalles.DataSource = tbl;
            conn.cerrarConexion();

        }

        public void mostrarDetallesVenta()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select producto,cantidad,precio,itbis,total from detalleventas where estado=1 and idcabeceraventa= @Idcabecera", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Idcabecera", dgvcabecera.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            dgvdetalles.DataSource = tbl;

            conn.cerrarConexion();
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            generarReporte();
        }

        private void dgvcabecera_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbtipo.Text == "Compras")
            {
                mostrardetallesCompras();
            }
            else if (cbtipo.Text == "Ventas")
            {
                mostrarDetallesVenta();
            }
        }
        public void exportarComprasSinDetalle(DataGridView tablaDatos)
        {
           
                Espera espera = new Espera();
                espera.Visible = true;

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                // excel.Application.Workbooks.Add(true);
                Microsoft.Office.Interop.Excel._Worksheet worksheet6; //declaracion de la hoja
                Microsoft.Office.Interop.Excel._Workbook Libro; // declaracion del libro

                Libro = (Microsoft.Office.Interop.Excel._Workbook)(excel.Workbooks.Add(System.Reflection.Missing.Value));
                worksheet6 = (Microsoft.Office.Interop.Excel._Worksheet)excel.Application.ActiveWorkbook.ActiveSheet;
                excel.DisplayAlerts = false;

                /*
                 *Range rango; 
                  rango= (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A1");


                Microsoft.Office.Interop.Excel.Pictures opicture = (Microsoft.Office.Interop.Excel.Pictures)excel.ActiveSheet.Pictures(System.Reflection.Missing.Value);
                excel.ActiveSheet.Shapes.Addpicture(@"\\56-1412\sisEvaluacionD\logomap.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 105, 45 /*float.Parse(rango.Left.ToString()), float.Parse(rango.Top.ToString()), float.Parse(rango.Width.ToString()), float.Parse(rango.Height.ToString()*/



                Range title;
                title = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E1", "I1");
                title.Value = "Amaurys AutoSong";
                title.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                title.Merge();
                title.Font.Name = "Gill Sans MT";
                title.Font.Size = 16;
                title.Font.Bold = true;
                title.Interior.ColorIndex = 35;
                title.Borders.ColorIndex = 1;

                Range titulo;
                titulo = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E2", "I2");
                titulo.Value = "Reporte De Compra desde: " + dtFechainicia.Text + " Hasta: " + dtfechafin.Text;
                titulo.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                titulo.Merge();
                titulo.Font.Name = "Gill Sans MT";
                titulo.Font.Size = 14;
                titulo.Font.Bold = true;
                titulo.Interior.ColorIndex = 35;
                titulo.Borders.ColorIndex = 1;





                /*
                 Range rango1;
                 rango1 = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A3", "E3");
                 rango1.Merge();
                 rango1.Value = "INSTITUCION:  " + "CORPORACION DE ACUEDUCTO Y ALCANTARILLADO DE SANTO DOMINGO(CAASD)";
                 rango1.Font.Name = "Gill Sans MT";
                 rango1.Font.Size = 10;
                 // rango1.Borders.ColorIndex = 1;
                 rango1.Font.Bold = true;
                 // rango1.Columns.AutoFit();*/

                /* Range rango2;
                 rango2 = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A2","B8");
                 rango2.Borders.ColorIndex = 1;*/

                Range tproducto;
                tproducto = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E7");
                tproducto.Value = "idcabeceracompra";
                tproducto.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tproducto.ColumnWidth = 30;


                tproducto.Font.Name = "Gill Sans MT";
                tproducto.Font.Size = 12;
                tproducto.Font.Bold = true;

                Range tcantidad;
                tcantidad = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F7");
                tcantidad.Value = "Numero De Compra";
                tcantidad.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                tcantidad.Font.Name = "Gill Sans MT";
                tcantidad.Font.Size = 12;
                tcantidad.Font.Bold = true;
                tcantidad.ColumnWidth = 30;


                Range tDescripcion;
                tDescripcion = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("G7");
                tDescripcion.Value = "Descripcion";
                tDescripcion.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                tDescripcion.Font.Name = "Gill Sans MT";
                tDescripcion.Font.Size = 12;
                tDescripcion.Font.Bold = true;
                tDescripcion.ColumnWidth = 30;

                Range tproveedor;
                tproveedor = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("H7");
                tproveedor.Value = "Proveedor";
                tproveedor.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                tproveedor.Font.Name = "Gill Sans MT";
                tproveedor.Font.Size = 12;
                tproveedor.Font.Bold = true;
                tproveedor.ColumnWidth = 30;

                Range tsubtotal;
                tsubtotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I7");
                tsubtotal.Value = "Subtotal";
                tsubtotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                tsubtotal.Font.Name = "Gill Sans MT";
                tsubtotal.Font.Size = 12;
                tsubtotal.Font.Bold = true;
                tsubtotal.ColumnWidth = 30;

                Range tItbis;
                tItbis = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("J7");
                tItbis.Value = "Itbis";
                tItbis.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                tItbis.Font.Name = "Gill Sans MT";
                tItbis.Font.Size = 12;
                tItbis.Font.Bold = true;
                tItbis.ColumnWidth = 30;

                Range ttotal;
                ttotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("K7");
                ttotal.Value = "Total";
                ttotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                ttotal.Font.Name = "Gill Sans MT";
                ttotal.Font.Size = 12;
                ttotal.Font.Bold = true;
                ttotal.ColumnWidth = 30;

                Range tfechacrea;
                tfechacrea = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("L7");
                tfechacrea.Value = "Fechacreacion";
                tfechacrea.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                tfechacrea.Font.Name = "Gill Sans MT";
                tfechacrea.Font.Size = 12;
                tfechacrea.Font.Bold = true;
                tfechacrea.ColumnWidth = 30;

                Range testado;
                testado = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("M7");
                testado.Value = "Estado";
                testado.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                testado.Font.Name = "Gill Sans MT";
                testado.Font.Size = 12;
                testado.Font.Bold = true;
                testado.ColumnWidth = 30;



                Range bordetitulos;
                bordetitulos = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E7", "M7");
                bordetitulos.Borders.ColorIndex = 1;
                bordetitulos.Interior.ColorIndex = 27;






                int indiceColumna = 0;

                foreach (DataGridViewColumn col in tablaDatos.Columns)
                {
                    if (col.Visible == false) continue;
                    {
                        indiceColumna++;
                        // excel.Cells[9, indiceColumna] = col.Name;

                    }

                }

                int indiceFila = 0;
                foreach (DataGridViewRow row in tablaDatos.Rows)
                {


                    indiceFila++;
                    indiceColumna = 0;
                    // tablaDatos.Columns.GetColumnsWidth = 40;







                    foreach (DataGridViewColumn col in tablaDatos.Columns)
                    {
                        if (col.Visible == false) continue;
                        indiceColumna++;
                        excel.Cells[indiceFila + 8, indiceColumna + 4] = row.Cells[col.Name].Value;
                        //  excel.Columns.RowHeight = 40;


                    }
                }
                /* indiceFila++;
                 Range range; //= excel.Cells[indiceFila + 12, indiceColumna - 10];
                 range = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("B15");
                 range.Value = "Sumatoria:";
                 range.Font.Name = "Gill Sans MT";
                 range.Font.Bold = true;
                 range.Columns.RowHeight = 40;
                 range.Borders.ColorIndex = 1;*/



                /* Range range3 = excel.Cells[indiceFila + 12, indiceColumna - 3];
                 range3.Value = dtFecha.Value.ToShortDateString();
                 range3.Columns.RowHeight = 40;*/

                excel.Visible = true;
                if (excel.Application.Visible == true)
                {
                    espera.Visible = false;


                }


            
        }
        public void exportarCompraCondetalles(DataGridView tablaDatos)
        {
           


                Espera espera = new Espera();
                espera.Visible = true;

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                // excel.Application.Workbooks.Add(true);
                Microsoft.Office.Interop.Excel._Worksheet worksheet6; //declaracion de la hoja
                Microsoft.Office.Interop.Excel._Workbook Libro; // declaracion del libro

                Libro = (Microsoft.Office.Interop.Excel._Workbook)(excel.Workbooks.Add(System.Reflection.Missing.Value));
                worksheet6 = (Microsoft.Office.Interop.Excel._Worksheet)excel.Application.ActiveWorkbook.ActiveSheet;
                excel.DisplayAlerts = false;

                /*
                 *Range rango; 
                  rango= (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A1");


                Microsoft.Office.Interop.Excel.Pictures opicture = (Microsoft.Office.Interop.Excel.Pictures)excel.ActiveSheet.Pictures(System.Reflection.Missing.Value);
                excel.ActiveSheet.Shapes.Addpicture(@"\\56-1412\sisEvaluacionD\logomap.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 105, 45 /*float.Parse(rango.Left.ToString()), float.Parse(rango.Top.ToString()), float.Parse(rango.Width.ToString()), float.Parse(rango.Height.ToString()*/



                Range title;
                title = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E1", "I1");
                title.Value = "Amaurys AutoSong";
                title.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                title.Merge();
                title.Font.Name = "Gill Sans MT";
                title.Font.Size = 16;
                title.Font.Bold = true;
                title.Interior.ColorIndex = 35;
                title.Borders.ColorIndex = 1;

                Range titulo;
                titulo = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E2", "I2");
                titulo.Value = "Reporte De Compra";
                titulo.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                titulo.Merge();
                titulo.Font.Name = "Gill Sans MT";
                titulo.Font.Size = 14;
                titulo.Font.Bold = true;
                titulo.Interior.ColorIndex = 35;
                titulo.Borders.ColorIndex = 1;


                Range tNcompra;
                tNcompra = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E4");
                tNcompra.Value = "# De Compra:";
                tNcompra.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                tNcompra.Font.Name = "Gill Sans MT";
                tNcompra.Font.Size = 10;
                tNcompra.Font.Bold = true;
                tNcompra.Interior.ColorIndex = 35;

                Range ncompra;
                ncompra = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F4");
                ncompra.Value = dgvcabecera.CurrentRow.Cells[2].Value.ToString();
                ncompra.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                // ncompra.Interior.ColorIndex = 35;

                ncompra.Font.Name = "Gill Sans MT";
                ncompra.Font.Size = 10;
                ncompra.Font.Bold = true;

                Range tfecha;
                tfecha = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E5");
                tfecha.Value = "Fecha";
                tfecha.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                // ncompra.Interior.ColorIndex = 35;

                tfecha.Font.Name = "Gill Sans MT";
                tfecha.Font.Size = 10;
                tfecha.Font.Bold = true;

                Range fecha;
                fecha = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F5");
                fecha.Value = dgvcabecera.CurrentRow.Cells[7].Value.ToString();
                fecha.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                // ncompra.Interior.ColorIndex = 35;

                fecha.Font.Name = "Gill Sans MT";
                fecha.Font.Size = 10;
                fecha.Font.Bold = true;

                Range tprveedor;
                tprveedor = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E6");
                tprveedor.Value = "Proveedor";
                tprveedor.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                 ncompra.Interior.ColorIndex = 35;

                tprveedor.Font.Name = "Gill Sans MT";
                tprveedor.Font.Size = 10;
                tprveedor.Font.Bold = true;

                Range proveedor;
                proveedor = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F6");
                proveedor.Value = dgvcabecera.CurrentRow.Cells[3].Value.ToString();
                proveedor.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                // ncompra.Interior.ColorIndex = 35;

                proveedor.Font.Name = "Gill Sans MT";
                proveedor.Font.Size = 10;
                proveedor.Font.Bold = true;

                Range tsubtotal;
                tsubtotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I4");
                tsubtotal.Value = "Subtotal";
                tsubtotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tsubtotal.Interior.ColorIndex = 35;

                tsubtotal.Font.Name = "Gill Sans MT";
                tsubtotal.Font.Size = 10;
                tsubtotal.Font.Bold = true;

                Range subtotal;
                subtotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("J4");
                subtotal.Value = dgvcabecera.CurrentRow.Cells[4].Value.ToString();
                subtotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;
               // subtotal.Interior.ColorIndex = 35;

                subtotal.Font.Name = "Gill Sans MT";
                subtotal.Font.Size = 10;
                subtotal.Font.Bold = true;

                Range tItbis;
                tItbis = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I5");
                tItbis.Value = "Itbis";
                tItbis.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tItbis.Interior.ColorIndex = 35;

                tItbis.Font.Name = "Gill Sans MT";
                tItbis.Font.Size = 10;
                tItbis.Font.Bold = true;

                Range Itbis;
                Itbis = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("J5");
                Itbis.Value = dgvcabecera.CurrentRow.Cells[5].Value.ToString();
                Itbis.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                // subtotal.Interior.ColorIndex = 35;

                Itbis.Font.Name = "Gill Sans MT";
                Itbis.Font.Size = 10;
                Itbis.Font.Bold = true;

                Range ttotal;
                ttotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I6");
                ttotal.Value = "Total";
                ttotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                ttotal.Interior.ColorIndex = 35;

                ttotal.Font.Name = "Gill Sans MT";
                ttotal.Font.Size = 10;
                ttotal.Font.Bold = true;

                Range total;
                total = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("J6");
                total.Value = dgvcabecera.CurrentRow.Cells[6].Value.ToString();
                total.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                // subtotal.Interior.ColorIndex = 35;

                total.Font.Name = "Gill Sans MT";
                total.Font.Size = 10;
                total.Font.Bold = true;

                /*
                 Range rango1;
                 rango1 = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A3", "E3");
                 rango1.Merge();
                 rango1.Value = "INSTITUCION:  " + "CORPORACION DE ACUEDUCTO Y ALCANTARILLADO DE SANTO DOMINGO(CAASD)";
                 rango1.Font.Name = "Gill Sans MT";
                 rango1.Font.Size = 10;
                 // rango1.Borders.ColorIndex = 1;
                 rango1.Font.Bold = true;
                 // rango1.Columns.AutoFit();*/

                /* Range rango2;
                 rango2 = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A2","B8");
                 rango2.Borders.ColorIndex = 1;*/

                Range tproducto;
                tproducto = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E8");
                tproducto.Value = "Producto";
                tproducto.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tproducto.ColumnWidth = 30;


                tproducto.Font.Name = "Gill Sans MT";
                tproducto.Font.Size = 12;
                tproducto.Font.Bold = true;

                Range tcantidad;
                tcantidad = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F8");
                tcantidad.Value = "Cantidad";
                tcantidad.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                tcantidad.Font.Name = "Gill Sans MT";
                tcantidad.Font.Size = 12;
                tcantidad.Font.Bold = true;
                tcantidad.ColumnWidth = 30;


                Range tDescripcion;
                tDescripcion = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("G8");
                tDescripcion.Value = "Descripcion";
                tDescripcion.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                tDescripcion.Font.Name = "Gill Sans MT";
                tDescripcion.Font.Size = 12;
                tDescripcion.Font.Bold = true;
                tDescripcion.ColumnWidth = 30;


                Range bordetitulos;
                bordetitulos = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E8", "G8");
                bordetitulos.Borders.ColorIndex = 1;
                bordetitulos.Interior.ColorIndex = 27;






                int indiceColumna = 0;

                foreach (DataGridViewColumn col in tablaDatos.Columns)
                {
                    if (col.Visible == false) continue;
                    {
                        indiceColumna++;
                        // excel.Cells[9, indiceColumna] = col.Name;

                    }

                }

                int indiceFila = 0;
                foreach (DataGridViewRow row in tablaDatos.Rows)
                {


                    indiceFila++;
                    indiceColumna = 0;
                    // tablaDatos.Columns.GetColumnsWidth = 40;







                    foreach (DataGridViewColumn col in tablaDatos.Columns)
                    {
                        if (col.Visible == false) continue;
                        indiceColumna++;
                        excel.Cells[indiceFila + 9, indiceColumna + 4] = row.Cells[col.Name].Value;
                        //  excel.Columns.RowHeight = 40;


                    }
                }
                /* indiceFila++;
                 Range range; //= excel.Cells[indiceFila + 12, indiceColumna - 10];
                 range = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("B15");
                 range.Value = "Sumatoria:";
                 range.Font.Name = "Gill Sans MT";
                 range.Font.Bold = true;
                 range.Columns.RowHeight = 40;
                 range.Borders.ColorIndex = 1;*/



                /* Range range3 = excel.Cells[indiceFila + 12, indiceColumna - 3];
                 range3.Value = dtFecha.Value.ToShortDateString();
                 range3.Columns.RowHeight = 40;*/

                excel.Visible = true;
                if (excel.Application.Visible == true)
                {
                    espera.Visible = false;


                }


            
        }

        public void exportarVentasSinDetalle(DataGridView tablaDatos)
        {

            Espera espera = new Espera();
            espera.Visible = true;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            // excel.Application.Workbooks.Add(true);
            Microsoft.Office.Interop.Excel._Worksheet worksheet6; //declaracion de la hoja
            Microsoft.Office.Interop.Excel._Workbook Libro; // declaracion del libro

            Libro = (Microsoft.Office.Interop.Excel._Workbook)(excel.Workbooks.Add(System.Reflection.Missing.Value));
            worksheet6 = (Microsoft.Office.Interop.Excel._Worksheet)excel.Application.ActiveWorkbook.ActiveSheet;
            excel.DisplayAlerts = false;

            /*
             *Range rango; 
              rango= (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A1");


            Microsoft.Office.Interop.Excel.Pictures opicture = (Microsoft.Office.Interop.Excel.Pictures)excel.ActiveSheet.Pictures(System.Reflection.Missing.Value);
            excel.ActiveSheet.Shapes.Addpicture(@"\\56-1412\sisEvaluacionD\logomap.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 105, 45 /*float.Parse(rango.Left.ToString()), float.Parse(rango.Top.ToString()), float.Parse(rango.Width.ToString()), float.Parse(rango.Height.ToString()*/



            Range title;
            title = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E1", "I1");
            title.Value = "Amaurys AutoSong";
            title.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            title.Merge();
            title.Font.Name = "Gill Sans MT";
            title.Font.Size = 16;
            title.Font.Bold = true;
            title.Interior.ColorIndex = 35;
            title.Borders.ColorIndex = 1;

            Range titulo;
            titulo = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E2", "I2");
            titulo.Value = "Reporte De Ventas desde: " + dtFechainicia.Text + " Hasta: " + dtfechafin.Text;
            titulo.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            titulo.Merge();
            titulo.Font.Name = "Gill Sans MT";
            titulo.Font.Size = 14;
            titulo.Font.Bold = true;
            titulo.Interior.ColorIndex = 35;
            titulo.Borders.ColorIndex = 1;





            /*
             Range rango1;
             rango1 = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A3", "E3");
             rango1.Merge();
             rango1.Value = "INSTITUCION:  " + "CORPORACION DE ACUEDUCTO Y ALCANTARILLADO DE SANTO DOMINGO(CAASD)";
             rango1.Font.Name = "Gill Sans MT";
             rango1.Font.Size = 10;
             // rango1.Borders.ColorIndex = 1;
             rango1.Font.Bold = true;
             // rango1.Columns.AutoFit();*/

            /* Range rango2;
             rango2 = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A2","B8");
             rango2.Borders.ColorIndex = 1;*/

            Range tproducto;
            tproducto = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E7");
            tproducto.Value = "idcabeceraVenta";
            tproducto.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            tproducto.ColumnWidth = 30;


            tproducto.Font.Name = "Gill Sans MT";
            tproducto.Font.Size = 12;
            tproducto.Font.Bold = true;

            Range tcantidad;
            tcantidad = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F7");
            tcantidad.Value = "Fecha";
            tcantidad.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tcantidad.Font.Name = "Gill Sans MT";
            tcantidad.Font.Size = 12;
            tcantidad.Font.Bold = true;
            tcantidad.ColumnWidth = 30;


            Range tDescripcion;
            tDescripcion = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("G7");
            tDescripcion.Value = "Numero de factura";
            tDescripcion.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tDescripcion.Font.Name = "Gill Sans MT";
            tDescripcion.Font.Size = 12;
            tDescripcion.Font.Bold = true;
            tDescripcion.ColumnWidth = 30;

            Range tproveedor;
            tproveedor = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("H7");
            tproveedor.Value = "Cliente";
            tproveedor.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tproveedor.Font.Name = "Gill Sans MT";
            tproveedor.Font.Size = 12;
            tproveedor.Font.Bold = true;
            tproveedor.ColumnWidth = 30;

            Range tsubtotal;
            tsubtotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I7");
            tsubtotal.Value = "Numero de Comprobante";
            tsubtotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tsubtotal.Font.Name = "Gill Sans MT";
            tsubtotal.Font.Size = 12;
            tsubtotal.Font.Bold = true;
            tsubtotal.ColumnWidth = 30;

            Range tItbis;
            tItbis = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("J7");
            tItbis.Value = "Subtotal";
            tItbis.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tItbis.Font.Name = "Gill Sans MT";
            tItbis.Font.Size = 12;
            tItbis.Font.Bold = true;
            tItbis.ColumnWidth = 30;

            Range ttotal;
            ttotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("K7");
            ttotal.Value = "Itbis";
            ttotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            ttotal.Font.Name = "Gill Sans MT";
            ttotal.Font.Size = 12;
            ttotal.Font.Bold = true;
            ttotal.ColumnWidth = 30;

            Range tfechacrea;
            tfechacrea = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("L7");
            tfechacrea.Value = "Total";
            tfechacrea.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tfechacrea.Font.Name = "Gill Sans MT";
            tfechacrea.Font.Size = 12;
            tfechacrea.Font.Bold = true;
            tfechacrea.ColumnWidth = 30;

           


            Range bordetitulos;
            bordetitulos = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E7", "L7");
            bordetitulos.Borders.ColorIndex = 1;
            bordetitulos.Interior.ColorIndex = 27;






            int indiceColumna = 0;

            foreach (DataGridViewColumn col in tablaDatos.Columns)
            {
                if (col.Visible == false) continue;
                {
                    indiceColumna++;
                    // excel.Cells[9, indiceColumna] = col.Name;

                }

            }

            int indiceFila = 0;
            foreach (DataGridViewRow row in tablaDatos.Rows)
            {


                indiceFila++;
                indiceColumna = 0;
                // tablaDatos.Columns.GetColumnsWidth = 40;







                foreach (DataGridViewColumn col in tablaDatos.Columns)
                {
                    if (col.Visible == false) continue;
                    indiceColumna++;
                    excel.Cells[indiceFila + 8, indiceColumna + 4] = row.Cells[col.Name].Value;
                    //  excel.Columns.RowHeight = 40;


                }
            }
            /* indiceFila++;
             Range range; //= excel.Cells[indiceFila + 12, indiceColumna - 10];
             range = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("B15");
             range.Value = "Sumatoria:";
             range.Font.Name = "Gill Sans MT";
             range.Font.Bold = true;
             range.Columns.RowHeight = 40;
             range.Borders.ColorIndex = 1;*/



            /* Range range3 = excel.Cells[indiceFila + 12, indiceColumna - 3];
             range3.Value = dtFecha.Value.ToShortDateString();
             range3.Columns.RowHeight = 40;*/

            excel.Visible = true;
            if (excel.Application.Visible == true)
            {
                espera.Visible = false;


            }



        }

        public void exportarVentasConDetalles( DataGridView tablaDatos)
        {

            Espera espera = new Espera();
            espera.Visible = true;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            // excel.Application.Workbooks.Add(true);
            Microsoft.Office.Interop.Excel._Worksheet worksheet6; //declaracion de la hoja
            Microsoft.Office.Interop.Excel._Workbook Libro; // declaracion del libro

            Libro = (Microsoft.Office.Interop.Excel._Workbook)(excel.Workbooks.Add(System.Reflection.Missing.Value));
            worksheet6 = (Microsoft.Office.Interop.Excel._Worksheet)excel.Application.ActiveWorkbook.ActiveSheet;
            excel.DisplayAlerts = false;

            /*
             *Range rango; 
              rango= (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A1");

            
            Microsoft.Office.Interop.Excel.Pictures opicture = (Microsoft.Office.Interop.Excel.Pictures)excel.ActiveSheet.Pictures(System.Reflection.Missing.Value);
            excel.ActiveSheet.Shapes.Addpicture(@"\\56-1412\sisEvaluacionD\logomap.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 105, 45 /*float.Parse(rango.Left.ToString()), float.Parse(rango.Top.ToString()), float.Parse(rango.Width.ToString()), float.Parse(rango.Height.ToString()*/



            Range title;
            title = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E1", "I1");
            title.Value = "Amaurys AutoSong";
            title.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            title.Merge();
            title.Font.Name = "Gill Sans MT";
            title.Font.Size = 16;
            title.Font.Bold = true;
            title.Interior.ColorIndex = 35;
            title.Borders.ColorIndex = 1;

            Range titulo;
            titulo = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E2", "I2");
            titulo.Value = "Reporte De Venta";
            titulo.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            titulo.Merge();
            titulo.Font.Name = "Gill Sans MT";
            titulo.Font.Size = 14;
            titulo.Font.Bold = true;
            titulo.Interior.ColorIndex = 35;
titulo.Borders.ColorIndex = 1;

            Range tfecha;
            tfecha = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("D4");
            tfecha.Value = "Fecha";
            tfecha.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;


            tfecha.Font.Name = "Gill Sans MT";
            tfecha.Font.Size = 12;
            tfecha.Font.Bold = true;

            Range fecha;
            fecha = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E4");
            fecha.Value = dgvcabecera.CurrentRow.Cells[1].Value.ToString();
            fecha.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;

            fecha.Font.Name = "Gill Sans MT";
            fecha.Font.Size = 12;
            fecha.Font.Bold = true;

            Range tnfactura;
            tnfactura = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("D5");
            tnfactura.Value = "# de Factura";
            tnfactura.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;


            tnfactura.Font.Name = "Gill Sans MT";
            tnfactura.Font.Size = 12;
            tnfactura.Font.Bold = true;

            Range nfactura;
            nfactura = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E5");
            nfactura.Value = dgvcabecera.CurrentRow.Cells[2].Value.ToString();
            nfactura.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;

            nfactura.Font.Name = "Gill Sans MT";
            nfactura.Font.Size = 12;
            nfactura.Font.Bold = true;

            Range tcliente;
            tcliente = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("D6");
            tcliente.Value = "Cliente";
            tcliente.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;


            tcliente.Font.Name = "Gill Sans MT";
            tcliente.Font.Size = 12;
            tcliente.Font.Bold = true;

            Range cliente;
            cliente = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E6");
            cliente.Value = dgvcabecera.CurrentRow.Cells[3].Value.ToString();
            cliente.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;

            cliente.Font.Name = "Gill Sans MT";
            cliente.Font.Size = 12;
            cliente.Font.Bold = true;

            Range tsubtotal;
            tsubtotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("H4");
            tsubtotal.Value = "Subtotal";
            tsubtotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;
            tsubtotal.Font.Name = "Gill Sans MT";
            tsubtotal.Font.Size = 12;
            tsubtotal.Font.Bold = true;

            Range subtotal;
            subtotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I4");
            subtotal.Value = dgvcabecera.CurrentRow.Cells[5].Value.ToString();
            subtotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;

            subtotal.Font.Name = "Gill Sans MT";
            subtotal.Font.Size = 12;
            subtotal.Font.Bold = true;

            Range ttitbis;
            ttitbis = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("H5");
            ttitbis.Value = "Itbis:";
            ttitbis.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;
            ttitbis.Font.Name = "Gill Sans MT";
            ttitbis.Font.Size = 12;
            ttitbis.Font.Bold = true;

            Range itbis;
            itbis = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I5");
            itbis.Value = dgvcabecera.CurrentRow.Cells[6].Value.ToString();
            itbis.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;

            itbis.Font.Name = "Gill Sans MT";
            itbis.Font.Size = 12;
            itbis.Font.Bold = true;

            Range ttotal;
            ttotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("H6");
            ttotal.Value = "Total:";
            ttotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;
            ttotal.Font.Name = "Gill Sans MT";
            ttotal.Font.Size = 12;
            ttotal.Font.Bold = true;

            Range total;
            total = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I6");
            total.Value = dgvcabecera.CurrentRow.Cells[7].Value.ToString();
            total.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // tproducto.ColumnWidth = 30;

            total.Font.Name = "Gill Sans MT";
            total.Font.Size = 12;
            total.Font.Bold = true;




            /*
             Range rango1;
             rango1 = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A3", "E3");
             rango1.Merge();
             rango1.Value = "INSTITUCION:  " + "CORPORACION DE ACUEDUCTO Y ALCANTARILLADO DE SANTO DOMINGO(CAASD)";
             rango1.Font.Name = "Gill Sans MT";
             rango1.Font.Size = 10;
             // rango1.Borders.ColorIndex = 1;
             rango1.Font.Bold = true;
             // rango1.Columns.AutoFit();*/

            /* Range rango2;
             rango2 = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("A2","B8");
             rango2.Borders.ColorIndex = 1;*/

            Range tproducto;
            tproducto = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E7");
            tproducto.Value = "Producto";
            tproducto.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            tproducto.ColumnWidth = 30;


            tproducto.Font.Name = "Gill Sans MT";
            tproducto.Font.Size = 12;
            tproducto.Font.Bold = true;

            Range tcantidad;
            tcantidad = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F7");
            tcantidad.Value = "Cantidad";
            tcantidad.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tcantidad.Font.Name = "Gill Sans MT";
            tcantidad.Font.Size = 12;
            tcantidad.Font.Bold = true;
            tcantidad.ColumnWidth = 30;


            Range tDescripcion;
            tDescripcion = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("G7");
            tDescripcion.Value = "precio";
            tDescripcion.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tDescripcion.Font.Name = "Gill Sans MT";
            tDescripcion.Font.Size = 12;
            tDescripcion.Font.Bold = true;
            tDescripcion.ColumnWidth = 30;

            Range titbis;
            titbis = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("H7");
            titbis.Value = "Itbis";
            titbis.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            titbis.Font.Name = "Gill Sans MT";
            titbis.Font.Size = 12;
            titbis.Font.Bold = true;
            titbis.ColumnWidth = 30;

            Range tTotal;
            tTotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I7");
            tTotal.Value = "Total";
            tTotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tTotal.Font.Name = "Gill Sans MT";
            tTotal.Font.Size = 12;
            tTotal.Font.Bold = true;
            tTotal.ColumnWidth = 30;


            Range bordetitulos;
            bordetitulos = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E7", "I7");
            bordetitulos.Borders.ColorIndex = 1;
            bordetitulos.Interior.ColorIndex = 27;






            int indiceColumna = 0;

            foreach (DataGridViewColumn col in tablaDatos.Columns)
            {
                if (col.Visible == false) continue;
                {
                    indiceColumna++;
                    // excel.Cells[9, indiceColumna] = col.Name;

                }

            }

            int indiceFila = 0;
            foreach (DataGridViewRow row in tablaDatos.Rows)
            {


                indiceFila++;
                indiceColumna = 0;
                // tablaDatos.Columns.GetColumnsWidth = 40;







                foreach (DataGridViewColumn col in tablaDatos.Columns)
                {
                    if (col.Visible == false) continue;
                    indiceColumna++;
                    excel.Cells[indiceFila + 8, indiceColumna + 4] = row.Cells[col.Name].Value;
                    //  excel.Columns.RowHeight = 40;


                }
                excel.Visible = true;
                if (excel.Application.Visible == true)
                {
                    espera.Visible = false;


                }
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if(cbtipo.Text=="Compras" && dgvdetalles.Rows.Count <= 0)
            {
                exportarComprasSinDetalle(dgvcabecera);
            }
            else if(cbtipo.Text == "Compras" && dgvdetalles.Rows.Count > 0)
            {
                exportarCompraCondetalles(dgvdetalles);
            }
            else if(cbtipo.Text == "Ventas" && dgvdetalles.Rows.Count <= 0)
            {
                exportarVentasSinDetalle(dgvcabecera);
            }
            else if(cbtipo.Text == "Ventas" && dgvdetalles.Rows.Count> 0)
            {
                exportarVentasConDetalles(dgvdetalles);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvdetalles.DataSource = null;
            dgvcabecera.DataSource = null;
        }

       
    }
}