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
    public partial class Ventas : Form
    {
        float preciodetalle;
        float itbisdetalle;
        float totaldetalle;
        Principal p = new Principal();
        Conexion conn = new Conexion();
        public Ventas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//// btnagregar
        {
            agregardetalleventa();
            
           // cbproducto.ResetText();
            txtpreciounit.Clear();
            txtitbisdetalle.Clear();
           // txtcodigobarra.Clear();
            txtdescuento.Clear();
            txtcantidaddetalle.Clear();
            txttotaldetalle.Clear();
            txtproducto.Clear();
                
        }

        public void llenarComboProducto(ComboBox cb)
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select producto from productos", conn.getConexion());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["producto"].ToString());
            }
            dr.Close();
            conn.cerrarConexion();
        }

        public void llenarCliente(ComboBox cb)
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select nombres, apellidos from clientes", conn.getConexion());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["nombres"].ToString());
            }
            dr.Close();
            conn.cerrarConexion();
        }

        private void Ventas_Load(object sender, EventArgs e)//////////////load/////////////
        {
            cargarNumeroFactura();
            // llenarComboProducto(cbproducto);
            // llenarCliente(cbclientes);
            cargarproducto();
            cargarcliente();
            txtTotalitbis.Text = "0";
            txtTotal.Text = "0";
            txtsubtotal.Text = "0";
            txttotaldetalle.Text = "0";
            txtdescuento.Text = "0";
            
        }
        public void cargarNumeroFactura()
        {
            conn.abrirConexion();

            int suma;

            string query = "select isnull (MAX(numerofactura), 0) as lastnumerocompra from cabeceraventas";
            SqlCommand command = new SqlCommand(query, conn.getConexion());

            int lastId = Convert.ToInt32(command.ExecuteScalar());
            suma = lastId + 1;
            txtnumerofactura.Text = suma.ToString();
            conn.cerrarConexion();

        }

        public void agregarCabeceraVenta()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("agregarcabeceraventas", conn.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcabeceraventa", txtid.Text);
            cmd.Parameters.AddWithValue("@cliente", txtcliente.Text);
           // cmd.Parameters.AddWithValue("@fechafactura", dtfecha.Text);
            cmd.Parameters.AddWithValue("@numerofactura", txtnumerofactura.Text);
            cmd.Parameters.AddWithValue("@tipocomprobante", cbtipocomprobante.Text);
            cmd.Parameters.AddWithValue("@numerocomprobante", txtceros.Text);
            cmd.Parameters.AddWithValue("@subtotal", txtsubtotal.Text);
            cmd.Parameters.AddWithValue("@itbis", txtTotalitbis.Text);
            cmd.Parameters.AddWithValue("@total", txtTotal.Text);
            
            cmd.Parameters.AddWithValue("@fechacrea", dtfecha.Text);
            cmd.Parameters.AddWithValue("@usrmodifica", InfoSistema.nombreUsuario);

            cmd.Parameters.AddWithValue("@estado", 1);
            //cmd.Parameters.AddWithValue("@tipoventa", Cbtipoventa.Text);
            //cmd.Parameters.AddWithValue("@fechalimitecredito", txtdiasCredito.Text);
            //cmd.Parameters.AddWithValue("@limitecredito", txtmontocredito.Text);


            cmd.ExecuteNonQuery();
            conn.cerrarConexion();
           // cbproducto.Focus();

        }

        private void txtdescripcion_KeyDown(object sender, KeyEventArgs e)
        {
          /*  if(e.KeyCode== Keys.Enter)
            {
                if(MessageBox.Show("pasar a productos?","VENTAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    agregarCabeceraVenta();
                    cargaridrelacion();
                }
            }*/
        }
        public void agregardetalleventa()
        {
           /* conn.abrirConexion();
            SqlCommand cmd1 = new SqlCommand("select limitedecredito from clientes where nombres='" + txtcliente.Text + "'", conn.getConexion());
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            System.Data.DataTable tbl1 = new System.Data.DataTable();
            da1.Fill(tbl1);
            conn.cerrarConexion();*/


           /* if (cbtipocomprobante.Text == "04" && float.Parse(txttotaldetalle.Text) + float.Parse(txtTotal.Text) > float.Parse(tbl1.Rows[0][0].ToString()))
            {
                MessageBox.Show("este ciente no tiene el credito suficiente para seguir comprando", "VENTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }*/

          //  else
           // {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("agregardetalleventas", conn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddetalleventa", txtid.Text);
                cmd.Parameters.AddWithValue("@producto", txtproducto.Text);
               // cmd.Parameters.AddWithValue("@codigodebarra", txtcodigobarra.Text);
                cmd.Parameters.AddWithValue("@cantidad", txtcantidaddetalle.Text);
                cmd.Parameters.AddWithValue("@precio", txtpreciounit.Text);
                cmd.Parameters.AddWithValue("@itbis", txtitbisdetalle.Text);
                cmd.Parameters.AddWithValue("@total", txttotaldetalle.Text);
            
                cmd.Parameters.AddWithValue("@descuento", float.Parse(txtdescuento.Text) / 100);

            
            cmd.Parameters.AddWithValue("@estado", 1);
                cmd.Parameters.AddWithValue("@idcabecera", txtrelacioncabecera.Text);


                cmd.ExecuteNonQuery();
               
                conn.cerrarConexion();
                mostrarDetalles();
                sumarAltotalCabecera();


           // }



        }



        public void mostrarDetalles()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select producto,cantidad,precio,itbis,descuento,total from detalleventas where estado=1 and idcabeceraventa= @Idcabecera", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Idcabecera", txtrelacioncabecera.Text);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
           System.Data. DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            dgvdetallesventa.DataSource = tbl;
            dgvdetallesventa.Columns[2].DefaultCellStyle.Format = "RD$0.00";
            dgvdetallesventa.Columns[3].DefaultCellStyle.Format = "RD$0.00";
            dgvdetallesventa.Columns[4].DefaultCellStyle.Format = "0.00%";
            dgvdetallesventa.Columns[5].DefaultCellStyle.Format = "RD$0.00";



            conn.cerrarConexion();
        }

        public void cargaridrelacion()
        {
            conn.abrirConexion();

            

            string query = "select isnull (MAX(idcabeceraventa), 0) as last from cabeceraventas";
            SqlCommand command = new SqlCommand(query, conn.getConexion());

            int lastId = Convert.ToInt32(command.ExecuteScalar());
            
            txtrelacioncabecera.Text = lastId.ToString();
            conn.cerrarConexion();

        }

        private void txtcodigobarra_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select ,preciodeventa,itbis from productos where producto='" + txtproducto.Text + "'", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            
            txtpreciounit.Text = tbl.Rows[0][0].ToString();
            txtitbisdetalle.Text = tbl.Rows[0][1].ToString();
            txtcantidaddetalle.Focus();
            conn.cerrarConexion();*/


        }

        private void txtcantidaddetalle_KeyDown(object sender, KeyEventArgs e)
        {
           
            if(e.KeyCode== Keys.Enter || e.KeyCode==Keys.Tab )
            {
                int existencia;
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("select existencia from productos where producto='" + txtproducto.Text + "'", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable tbl = new System.Data.DataTable();
                da.Fill(tbl);
                conn.cerrarConexion();
                existencia = int.Parse(tbl.Rows[0][0].ToString());
                if(existencia>= int.Parse(txtcantidaddetalle.Text))
                {
                    int multiplicador = int.Parse(txtcantidaddetalle.Text);
                    itbisdetalle = float.Parse(txtitbisdetalle.Text) * multiplicador;
                    preciodetalle = float.Parse(txtpreciounit.Text);
                    totaldetalle = preciodetalle * multiplicador + itbisdetalle;
                    txtitbisdetalle.Text = itbisdetalle.ToString();
                    txttotaldetalle.Text = totaldetalle.ToString("0.00");

                }
                else
                {
                    MessageBox.Show("estas excediendo la cantidad de producto en inventario", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
           
           

        }

        private void txtdescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                int cantidadporciento = int.Parse(txtdescuento.Text);
                float porciento = totaldetalle * cantidadporciento / 100;
                float totalcondescuento = totaldetalle - porciento;
                txttotaldetalle.Text = totalcondescuento.ToString("0.00");


            }
        }
        public void sumarAltotalCabecera()
        {
           float sumatotal = float.Parse(txttotaldetalle.Text) + float.Parse(txtTotal.Text);
            txtTotal.Text = sumatotal.ToString();
            /////////////////////////////////////////////
            float cantidad = preciodetalle * int.Parse(txtcantidaddetalle.Text);
            float subtotal = cantidad + float.Parse(txtsubtotal.Text);
            txtsubtotal.Text = subtotal.ToString();
            //////////////////////////////////////////////
            float itbiscabecera = itbisdetalle + float.Parse(txtTotalitbis.Text);
            txtTotalitbis.Text = itbiscabecera.ToString();
        }
        public void eliminardetalle()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("update detalleventas set estado='0' where producto= @producto and cantidad=@cantidad", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@producto", dgvdetallesventa.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@cantidad", int.Parse(dgvdetallesventa.CurrentRow.Cells[1].Value.ToString()));

            cmd.ExecuteNonQuery();
            conn.cerrarConexion();
        }

        public void restarAlaCabecera()
        {
            float restatotal = float.Parse(txtTotal.Text) - float.Parse(dgvdetallesventa.CurrentRow.Cells[4].Value.ToString());
            txtTotal.Text = restatotal.ToString();
            /////////////////////////////////////////////
            float cantidad = float.Parse(txtsubtotal.Text) - float.Parse(dgvdetallesventa.CurrentRow.Cells[2].Value.ToString())* float.Parse( dgvdetallesventa.CurrentRow.Cells[1].Value.ToString());
            
            txtsubtotal.Text = cantidad.ToString();
            //////////////////////////////////////////////
            float itbiscabecera = float.Parse(txtTotalitbis.Text) - float.Parse(dgvdetallesventa.CurrentRow.Cells[3].Value.ToString())* float.Parse(dgvdetallesventa.CurrentRow.Cells[1].Value.ToString());
            txtTotalitbis.Text = itbiscabecera.ToString();

        }

        private void btnEliminardetalle_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("estas seguro que deseas eliminar?","VENTAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                eliminardetalle();
                restarAlaCabecera();
                mostrarDetalles();
            }
           
        }
        public void cargarNfc()
        {
            conn.abrirConexion();
            SqlCommand cmd1 = new SqlCommand("select MAX(fechavencimiento) from comprobantefiscal where tipocomprobante='" + cbtipocomprobante.Text + "' and estado='1'", conn.getConexion());
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            System.Data.DataTable tbl1 = new System.Data.DataTable();
            da1.Fill(tbl1);
            conn.cerrarConexion();
            DateTime fechaActual = dtfecha.Value;

            DateTime fechavencimiento = DateTime.Parse( tbl1.Rows[0][0].ToString());
            int resultfecha = DateTime.Compare(fechaActual, fechavencimiento);

           
           if(resultfecha<0)
            {

                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("select nfc from comprobantefiscal where tipocomprobante='" + cbtipocomprobante.Text + "' and estado='1' order by idcomprobante desc", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable tbl = new System.Data.DataTable();
                da.Fill(tbl);
                conn.cerrarConexion();
                if (int.Parse(tbl.Rows[0][0].ToString()) > 0)
                {

                   // txtnumerocomprobante.Text = tbl.Rows[0][0].ToString();

                    string cantidadCeros;
                    int maximoseciencia = int.Parse(tbl.Rows[0][0].ToString());
                    if (maximoseciencia < 10)
                    {
                        cantidadCeros = "0000000";
                    }
                    else if (maximoseciencia >= 10 && maximoseciencia < 100)
                    {
                        cantidadCeros = "000000";
                    }
                    else if (maximoseciencia >= 100 && maximoseciencia < 1000)
                    {
                        cantidadCeros = "00000";
                    }
                    else if (maximoseciencia >= 1000 && maximoseciencia < 10000)
                    {
                        cantidadCeros = "0000";
                    }
                    else if (maximoseciencia >= 10000 && maximoseciencia < 100000)
                    {
                        cantidadCeros = "000";
                    }
                    else if (maximoseciencia >= 100000 && maximoseciencia < 1000000)
                    {
                        cantidadCeros = "00";
                    }
                    else if (maximoseciencia >= 1000000 && maximoseciencia < 10000000)
                    {
                        cantidadCeros = "0";
                    }
                    else
                    {
                        cantidadCeros = "";
                    }
                    txtceros.Text = cantidadCeros+maximoseciencia;
                   // conn.cerrarConexion();

                }
                else
                {
                    MessageBox.Show("no dispone de este tipo de comprobante, solicitar a la DGII", "COMPROBANTE FISCAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else if(resultfecha==0)
            {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("select MAX(nfc) from comprobantefiscal where tipocomprobante='" + cbtipocomprobante.Text + "' and estado='1'", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable tbl = new System.Data.DataTable();
                da.Fill(tbl);
                conn.cerrarConexion();
                    
                if (int.Parse(tbl.Rows[0][0].ToString()) > 0)
                {

                   // txtnumerocomprobante.Text = tbl.Rows[0][0].ToString();

                    string cantidadCeros;
                    int maximoseciencia = int.Parse(tbl.Rows[0][0].ToString());
                    if (maximoseciencia < 10)
                    {
                        cantidadCeros = "0000000";
                    }
                    else if (maximoseciencia >= 10 && maximoseciencia < 100)
                    {
                        cantidadCeros = "000000";
                    }
                    else if (maximoseciencia >= 100 && maximoseciencia < 1000)
                    {
                        cantidadCeros = "00000";
                    }
                    else if (maximoseciencia >= 1000 && maximoseciencia < 10000)
                    {
                        cantidadCeros = "0000";
                    }
                    else if (maximoseciencia >= 10000 && maximoseciencia < 100000)
                    {
                        cantidadCeros = "000";
                    }
                    else if (maximoseciencia >= 100000 && maximoseciencia < 1000000)
                    {
                        cantidadCeros = "00";
                    }
                    else if (maximoseciencia >= 1000000 && maximoseciencia < 10000000)
                    {
                        cantidadCeros = "0";
                    }
                    else
                    {
                        cantidadCeros = "";
                    }
                    txtceros.Text = cantidadCeros+ maximoseciencia;
                   // conn.cerrarConexion();

                }
                else
                {
                    MessageBox.Show("no dispone de este tipo de comprobante, solicitar a la DGII", "COMPROBANTE FISCAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show("este tipo de compromprobante expira hoy!, favor comunicarse con la DGII", "COMPROBANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("este tipo de comprobante ha expirado, favor comunicarse con la DGII","COMPROBANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void cbtipocomprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarNfc();
            txtcliente.Focus();
        }

        public void restarAinventario(DataGridView tabla)
        {
            conn.abrirConexion();
            string query = "update productos set existencia= existencia - @cantidadArestar where producto=@producto";
            SqlCommand cmd = new SqlCommand(query, conn.getConexion());
            foreach (DataGridViewRow row in tabla.Rows)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cantidadArestar", Convert.ToInt32(row.Cells[1].Value));
                cmd.Parameters.AddWithValue("@producto", Convert.ToString(row.Cells[0].Value));



                cmd.ExecuteNonQuery();
            }
            conn.cerrarConexion();
            Inventario inv = new Inventario();
            inv.mostrarInventario();
            // MessageBox.Show("datos insertados correctamente!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void restarComprobante()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("update comprobantefiscal set nfc= nfc-1 where tipocomprobante='" + cbtipocomprobante.Text + "' and estado='1'", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.cerrarConexion();
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
            titulo.Value = "Factura";
            titulo.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            titulo.Merge();
            titulo.Font.Name = "Gill Sans MT";
            titulo.Font.Size = 14;
            titulo.Font.Bold = true;
            titulo.Interior.ColorIndex = 35;
            titulo.Borders.ColorIndex = 1;

            Range tncomprobante;
            tncomprobante = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E4");
            tncomprobante.Value = "Comprobante No:";
            tncomprobante.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tncomprobante.Font.Name = "Gill Sans MT";
            tncomprobante.Font.Size = 10;
            tncomprobante.Font.Bold = true;
            tncomprobante.Interior.ColorIndex = 35;

            Range ncomprobante;
            ncomprobante = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F4");
            ncomprobante.NumberFormat = "@";
            ncomprobante.Value = txtceros.Text;
            ncomprobante.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            ncomprobante.Interior.ColorIndex = 35;

            ncomprobante.Font.Name = "Gill Sans MT";
            ncomprobante.Font.Size = 10;
            ncomprobante.Font.Bold = true;


            Range tfecha;
            tfecha = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E5");
            tfecha.Value = "Fecha:";
            tfecha.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tfecha.Font.Name = "Gill Sans MT";
            tfecha.Font.Size = 10;
            tfecha.Font.Bold = true;
            tfecha.Interior.ColorIndex = 35;

            Range fecha;
            fecha = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("F5");
            fecha.Value = dtfecha.Text;
            fecha.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            fecha.Interior.ColorIndex = 35;

            fecha.Font.Name = "Gill Sans MT";
            fecha.Font.Size = 10;
            fecha.Font.Bold = true;
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

            Range tdescuento;
            tdescuento = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("I7");
            tdescuento.Value = "Descuento";
            tdescuento.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tdescuento.Font.Name = "Gill Sans MT";
            tdescuento.Font.Size = 12;
            tdescuento.Font.Bold = true;
            tdescuento.ColumnWidth = 30;

            Range tTotal;
            tTotal = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("J7");
            tTotal.Value = "Total";
            tTotal.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tTotal.Font.Name = "Gill Sans MT";
            tTotal.Font.Size = 12;
            tTotal.Font.Bold = true;
            tTotal.ColumnWidth = 30;


            Range bordetitulos;
            bordetitulos = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E7", "J7");
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
                excel.Cells[indiceColumna + 6].NumberFormat = "[$$-RD] #,##0.00 ";
                // tablaDatos.Columns.GetColumnsWidth = 40;







                foreach (DataGridViewColumn col in tablaDatos.Columns)
                {
                    if (col.Visible == false) continue;
                    indiceColumna++;
                    excel.Cells[indiceFila + 8, indiceColumna + 4] = row.Cells[col.Name].Value;
                    //  excel.Columns.RowHeight = 40;


                }
            }
            indiceFila++;
            Range range;
            range= excel.Cells[indiceFila+8 , indiceColumna - 1];
            range.Value = "subtotal:";
            range.Font.Bold = true;
            range.Font.Size = 12;

            Range rangesubtotal;
            rangesubtotal = excel.Cells[indiceFila + 8, indiceColumna ];
            rangesubtotal.Value = txtsubtotal.Text;
            rangesubtotal.Font.Bold = true;
            rangesubtotal.Font.Size = 12;
            rangesubtotal.NumberFormat = "[$$-RD] #,##0.00 ";


            Range rangeitbis;
            rangeitbis = excel.Cells[indiceFila + 9, indiceColumna - 1];
            rangeitbis.Value = "Itbis:";
            rangeitbis.Font.Bold = true;
            rangeitbis.Font.Size = 12;

            Range rangetitbis;
            rangetitbis =  excel.Cells[indiceFila + 9, indiceColumna ];
            rangetitbis.Value = txtTotalitbis.Text;
            rangetitbis.Font.Bold = true;
            rangetitbis.Font.Size = 12;
           
           rangetitbis.NumberFormat= "[$$-RD] #,##0.00 ";
         //  excel.Cells[40,"B"].NumberFormat = "#,##.00 RD$";







            Range total;
            total = excel.Cells[indiceFila + 10, indiceColumna - 1];
            total.Value = "Total:";
            total.Font.Bold = true;
            total.Font.Size = 12;



            Range ttotal;
            ttotal = excel.Cells[indiceFila + 10, indiceColumna ];
            ttotal.Value = txtTotal.Text;
            ttotal.Font.Bold = true;
            ttotal.Font.Size = 12;
            ttotal.NumberFormat = "[$$-RD] #,##0.00 ";


            Range efectivirecibido;
            efectivirecibido = excel.Cells[indiceFila + 11, indiceColumna - 1];
            efectivirecibido.Value = "Efectivo Recibido:";
            efectivirecibido.Font.Bold = true;
            efectivirecibido.Font.Size = 12;


            Range tefectivirecibido;
            tefectivirecibido = excel.Cells[indiceFila + 11, indiceColumna];
            tefectivirecibido.Value = txtEfectivoRecibido.Text;
            tefectivirecibido.Font.Bold = true;
            tefectivirecibido.Font.Size = 12;
            tefectivirecibido.NumberFormat = "[$$-RD] #,##0.00 ";


            Range devuelta;
            devuelta = excel.Cells[indiceFila + 12, indiceColumna - 1];
            devuelta.Value = "Devuelta:";
            devuelta.Font.Bold = true;
            devuelta.Font.Size = 12;


            Range tdevuelta;
            tdevuelta = excel.Cells[indiceFila + 12, indiceColumna];
            tdevuelta.Value = txtdevuelta.Text;
            tdevuelta.Font.Bold = true;
            tdevuelta.Font.Size = 12;
            tdevuelta.NumberFormat = "[$$-RD] #,##0.00 ";


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

        private void btnfactura_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEfectivoRecibido.Text) || string.IsNullOrEmpty(txtdevuelta.Text))
            {
                MessageBox.Show("¡ no puede haber campos en blanco!", "FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                exportarExcel(dgvdetallesventa);
                restarAinventario(dgvdetallesventa);
                restarComprobante();
                cbtipocomprobante.Text = "Tipo De Comprobante";
                // cbclientes.Text = "Clientes";
                // txtdescripcion.Clear();
                cargarNumeroFactura();
                // txtnumerocomprobante.Clear();
                txtcliente.Clear();
                txtceros.Clear();
                txtsubtotal.Text = "0";
                txtTotalitbis.Text = "0";
                txtTotal.Text = "0";
                dgvdetallesventa.DataSource = null;
                txtEfectivoRecibido.Clear();
                txtdevuelta.Clear();


            }


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtpreciounit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void txtdescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void txtpreciounit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {
            if (txtcliente.Text != null)
            {
                dgvbuscarcliente.Visible = true;
                dgvbuscarcliente.CurrentCell = null;
                foreach (DataGridViewRow r in dgvbuscarcliente.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvbuscarcliente.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtcliente.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                    if (txtcliente.Text.Length <= 0)
                    {
                        dgvbuscarcliente.Visible = false;
                    }
                }
            }
        }

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            if (txtproducto.Text != null)
            {
                dgvbuscarproducto.Visible = true;
                dgvbuscarproducto.CurrentCell = null;
                foreach (DataGridViewRow r in dgvbuscarproducto.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvbuscarproducto.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtproducto.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                    if (txtproducto.Text.Length <= 0)
                    {
                        dgvbuscarproducto.Visible = false;
                    }
                }
            }

        }

        public void cargarproducto()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select producto from productos", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            dgvbuscarproducto.DataSource = tbl;
            conn.cerrarConexion();
        }

        public void cargarcliente()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select nombres,apellidos,telefono from clientes", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            dgvbuscarcliente.DataSource = tbl;
            conn.cerrarConexion();
        }

        private void dgvbuscarcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcliente.Text = dgvbuscarcliente.CurrentRow.Cells[0].Value.ToString()+" "+ dgvbuscarcliente.CurrentRow.Cells[1].Value.ToString();
            dgvbuscarcliente.Visible = false;
        }

        private void dgvbuscarproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            float preciounit;
            float itbisdetalle;
            txtproducto.Text = dgvbuscarproducto.CurrentRow.Cells[0].Value.ToString();
             conn.abrirConexion();
           SqlCommand cmd = new SqlCommand("select preciodeventa,itbis from productos where producto='" + txtproducto.Text + "'", conn.getConexion());
           cmd.CommandType = CommandType.Text;
           cmd.ExecuteNonQuery();

           SqlDataAdapter da = new SqlDataAdapter(cmd);
           System.Data.DataTable tbl = new System.Data.DataTable();
           da.Fill(tbl);

           preciounit = float.Parse(tbl.Rows[0][0].ToString());
           itbisdetalle=  float.Parse(tbl.Rows[0][1].ToString());
            txtpreciounit.Text = preciounit.ToString("0.00");
            txtitbisdetalle.Text = itbisdetalle.ToString("0.00");
           txtcantidaddetalle.Focus();
           conn.cerrarConexion();
            dgvbuscarproducto.Visible = false;
        }

        private void btnagregarcabecera_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("pasar a productos?", "VENTAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agregarCabeceraVenta();
                cargaridrelacion();
                txtproducto.Focus();
            }
        }

        private void Cbtipoventa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(Cbtipoventa.Text=="Credito")
            //{
            //    lbldiasCredito.Enabled = true;
            //    txtdiasCredito.Enabled = true;
            //    lblmontoCredito.Enabled = true;
            //    txtmontocredito.Enabled = true;
            //    txtdiasCredito.Focus();
            //}
        }

        private void dgvbuscarproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregardetalleventa();

            // cbproducto.ResetText();
            txtpreciounit.Clear();
            txtitbisdetalle.Clear();
            // txtcodigobarra.Clear();
            txtdescuento.Text="0";
            txtcantidaddetalle.Clear();
            txttotaldetalle.Clear();
            txtproducto.Clear();

        }

        public void calcularDevuelta()
        {
            if (float.Parse(txtEfectivoRecibido.Text) >= float.Parse(txtTotal.Text))
            {

           
            float devuelta;
           devuelta = float.Parse(txtEfectivoRecibido.Text) - float.Parse(txtTotal.Text);
            txtdevuelta.Text = devuelta.ToString("0.00");
            }
            else
            {
                MessageBox.Show("la cantidad recibida no es suficiente!", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEfectivoRecibido_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter || e.KeyCode== Keys.Tab)
            {
                calcularDevuelta();
            }
        }
    }
}
