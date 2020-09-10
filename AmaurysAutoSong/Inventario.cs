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
    public partial class Inventario : Form
    {
        Conexion conn = new Conexion();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)////////load////////////
        {
            llenarcomboboxCategoria(cbCategoria);
           // mostrarInventario();
        }
        public void mostrarInventario()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select producto, categoria,existencia, costo, preciodeventa from productos order by categoria", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
           System.Data. DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            dgvInventario.DataSource = tbl;
            dgvInventario.Columns[3].DefaultCellStyle.Format = "RD$0.00";
            dgvInventario.Columns[4].DefaultCellStyle.Format = "RD$0.00";



            conn.cerrarConexion();
        }

        public void llenarcomboboxCategoria(ComboBox cb)  //llenar el combobox de categorias////////////
        {

            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select categoria from categorias", conn.getConexion());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["categoria"].ToString());
            }
            dr.Close();
            conn.cerrarConexion();


        }

        public void buscar()
        {
if(txtproducto.Text.Length>0 && cbCategoria.Text == "Categoria")
            {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("select  producto, categoria, existencia, costo, preciodeventa from productos where producto='" + txtproducto.Text + "'", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable tbl = new System.Data.DataTable();
                da.Fill(tbl);
                dgvInventario.DataSource = tbl;
                conn.cerrarConexion();
            }
else if(string.IsNullOrEmpty(txtproducto.Text)&& cbCategoria.Text != "Categoria")
            {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("select  producto, categoria,existencia, costo, preciodeventa from productos where categoria='" + cbCategoria.Text + "'", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable tbl = new System.Data.DataTable();
                da.Fill(tbl);
                dgvInventario.DataSource = tbl;
                conn.cerrarConexion();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        public void exportarExcel(DataGridView tablaDatos)//////////////exportar a excel////////////////////////

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
            title.Value = "Amaurys AutoSound";
            title.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            title.Merge();
            title.Font.Name = "Gill Sans MT";
            title.Font.Size = 16;
            title.Font.Bold = true;
            title.Interior.ColorIndex = 35;
            title.Borders.ColorIndex = 1;

            Range titulo;
            titulo = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E2", "I2");
            titulo.Value = "Inventario De Productos";
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
            tproducto.Value = "Producto";
            tproducto.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            tproducto.ColumnWidth = 30;


            tproducto.Font.Name = "Gill Sans MT";
            tproducto.Font.Size = 12;
            tproducto.Font.Bold = true;

            Range tcantidad;
            tcantidad = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F7");
            tcantidad.Value = "Categoria";
            tcantidad.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tcantidad.Font.Name = "Gill Sans MT";
            tcantidad.Font.Size = 12;
            tcantidad.Font.Bold = true;
            tcantidad.ColumnWidth = 30;


            Range tDescripcion;
            tDescripcion = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("G7");
            tDescripcion.Value = "Existencia";
            tDescripcion.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tDescripcion.Font.Name = "Gill Sans MT";
            tDescripcion.Font.Size = 12;
            tDescripcion.Font.Bold = true;
             tDescripcion.ColumnWidth = 30;

            Range tcosto;
            tcosto = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("H7");
            tcosto.Value = "Costo";
            tcosto.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tcosto.Font.Name = "Gill Sans MT";
            tcosto.Font.Size = 12;
            tcosto.Font.Bold = true;
            tcosto.ColumnWidth = 30;

            Range tventa;
            tventa = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I7");
            tventa.Value = "Precio De Venta";
            tventa.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tventa.Font.Name = "Gill Sans MT";
            tventa.Font.Size = 12;
            tventa.Font.Bold = true;
            tventa.ColumnWidth = 30;


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


            // range.Value = indiceFila;
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            exportarExcel(dgvInventario);
        }

        private void Inventario_Paint(object sender, PaintEventArgs e)
        {
            mostrarInventario();
        }
    }
}
