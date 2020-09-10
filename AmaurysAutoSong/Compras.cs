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
    public partial class Compras : Form
    {
        Conexion conn = new Conexion();

        float cantidad;
        int multiplicador;
        float total;
        float itbisdetalle;
        float descuentoCabecera;
        
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)//////load
        {
            cargarNumerodeCompra();
            llenarComboProveedor(cbproveedor);
            // llenarComboProducto(cbproductoCompra);
            // mostrardetalles();
            // cbproductoCompra.Text = "Producto";
            txtTotal.Text = "0";
            txtItbis.Text = "0";
            txtSubtotal.Text = "0";
            txtDescuento.Text = "0";
            MostrarCompras();
            cargarproducto();
        }
        public void llenarComboProveedor(ComboBox cb)
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select nombres from proveedor", conn.getConexion());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["nombres"].ToString());
            }
            dr.Close();
            conn.cerrarConexion();

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar b = new Buscar();
            b.Show();
            b.BringToFront();
            // Hide();
        }
        public void cargarNumerodeCompra()
        {
           // if (string.IsNullOrEmpty(txtidcabecera.Text))
          //  {
                conn.abrirConexion();

                int suma;

                string query = "select isnull (MAX(numerocompra), 0) as lastnumerocompra from cabeceracompra";
                SqlCommand command = new SqlCommand(query, conn.getConexion());

                int lastId = Convert.ToInt32(command.ExecuteScalar());
                suma = lastId + 1;
                txtnumerocompra.Text = suma.ToString();
                conn.cerrarConexion();

         //   }


        }

        private void cbproductoCompra_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtcantidad.Focus();

        }

        private void cbproductoCompra_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void insertardetalles()
        {

            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("agregardetallecompra", conn.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iddetallecompra", txtidetalle.Text);
            cmd.Parameters.AddWithValue("@producto", txtproducto.Text);



            cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
            // cmd.Parameters.AddWithValue("@descripcion", txtdescripcionDetalle.Text);

            cmd.Parameters.AddWithValue("@idcabeceracompra", txtnumerocompra.Text);

            cmd.Parameters.AddWithValue("@estado", 1);


            cmd.ExecuteNonQuery();
            conn.cerrarConexion();

        }

        public void mostrardetalles()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select producto,cantidad from detallecompras where idcabeceracompra='" + txtnumerocompra.Text + "' ", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            // cmd.Parameters.AddWithValue("@idcabeceracompra", txtnumerocompra.Text);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            dgvDetalles.DataSource = tbl;
            conn.cerrarConexion();
        }


        private void btnAgregardetalle_Click(object sender, EventArgs e)
        {
            //  TotalDeDetalle();

            insertardetalles();
            mostrardetalles();

            //calcularDescuento();
            // txtTotal.Text = txttotaldetalle.Text;
            txtproducto.Clear();
            txtcantidad.Clear();
            // txtdescripcionDetalle.Clear();
            btnguardarcompra.Enabled = true;

        }





        private void txtDescuentoDetalle_KeyDown(object sender, KeyEventArgs e)
        {

        }
        public void insertarCabecera()
        {
            if (MessageBox.Show("pasar a los detalles de la orden de compra?", "COMPRA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("agregarcabeceracompra", conn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcabeceracompra", txtidcabecera.Text);
                cmd.Parameters.AddWithValue("@numerocompra", txtnumerocompra.Text);

                cmd.Parameters.AddWithValue("@proveedor", cbproveedor.Text);


                //cmd.Parameters.AddWithValue("@descripcion", txtdescripcionCabecera.Text);


                cmd.Parameters.AddWithValue("@fechacrea", dtfechaEmision.Text);
                cmd.Parameters.AddWithValue("@estado", "abierta");
                // cmd.Parameters.AddWithValue("@tipocomprobante", cbTipoComprobante.Text);

                cmd.ExecuteNonQuery();
                conn.cerrarConexion();


            }
            txtproducto.Focus();

        }
        public void eliminardetalle()
        {
            float totalcabecera = float.Parse(txtTotal.Text);
            float cantidadArestar = float.Parse(dgvDetalles.CurrentRow.Cells[5].Value.ToString());
            float totalresta = totalcabecera - cantidadArestar;
            int id = int.Parse(dgvDetalles.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("estas seguro que quieres eliminar de la compra?", "COMPRA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtTotal.Text = totalresta.ToString();
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("update detallecompras set estado='0' where iddetallecompra= @id", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.cerrarConexion();
                MessageBox.Show("eliminado!");
            }
        }

        private void btnEliminardetalle_Click(object sender, EventArgs e)
        {
            eliminardetalle();
            mostrardetalles();
        }

        private void txtdescripcionCabecera_KeyDown(object sender, KeyEventArgs e)
        {
          /*  if (e.KeyCode == Keys.Enter)
            {
                insertarCabecera();
            }*/
        }

        public void CompletarCabecera()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("update cabeceracompra set subtotal='" + txtSubtotal.Text + "', itbis='" + txtItbis.Text + "', total='" + txtTotal.Text + "',tipoComprobante='" + cbTipoComprobante.Text + "', numerocomprobante='" + txtcomprobante.Text + "', fechafactura='" + dtfechafactura.Text + "', TipoDocumento='"+ cbtipoDocumento.Text+"' where idcabeceracompra=@id", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", txtidcabecera.Text);
            cmd.ExecuteNonQuery();
            conn.cerrarConexion();

        }

        private void btnguardarcompra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidcabecera.Text) )
            {
                if (MessageBox.Show("estas seguro que desea registrar esta orden de compra?", "ORDEN DE COMPRA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dgvDetalles.Rows.Count>0)
                {
                    // CompletarCabecera();
                    MessageBox.Show("Orden guardada correctamente", "ORDEN DE COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
               
            }
           

            else
            {
                CompletarCabecera();
                insertarAinventario(dgvDetalles);
                MessageBox.Show("datos guarados correctamente", "COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MostrarCompras();
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
            titulo.Value = "Orden De Compra";
            titulo.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            titulo.Merge();
            titulo.Font.Name = "Gill Sans MT";
            titulo.Font.Size = 14;
            titulo.Font.Bold = true;
            titulo.Interior.ColorIndex = 35;
            titulo.Borders.ColorIndex = 1;


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
            fecha.Value = dtfechaEmision.Text;
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
            tDescripcion.Value = "Descripcion";
            tDescripcion.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            tDescripcion.Font.Name = "Gill Sans MT";
            tDescripcion.Font.Size = 12;
            tDescripcion.Font.Bold = true;
            tDescripcion.ColumnWidth = 30;


            Range bordetitulos;
            bordetitulos = (Microsoft.Office.Interop.Excel.Range)worksheet6.get_Range("E7", "G7");
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

        public void insertarAinventario(DataGridView tabla)
        {
            conn.abrirConexion();
            string query = "update productos set existencia= existencia + @cantidadAinsertar where producto=@producto";
            SqlCommand cmd = new SqlCommand(query, conn.getConexion());
            foreach (DataGridViewRow row in tabla.Rows)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cantidadAinsertar", Convert.ToInt32(row.Cells[1].Value));
                cmd.Parameters.AddWithValue("@producto", Convert.ToString(row.Cells[0].Value));



                cmd.ExecuteNonQuery();
            }
            conn.cerrarConexion();
           // MessageBox.Show("datos insertados correctamente!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cambiarestadoCabecera();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportarExcel(dgvDetalles);
        }

        private void gbDetalles_Enter(object sender, EventArgs e)
        {

        }
        public void cambiarestadoCabecera()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("update cabeceracompra set estado= 'cerrada' where idcabeceracompra=@idcabecera", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idcabecera", txtidcabecera.Text);
            cmd.ExecuteNonQuery();
            conn.cerrarConexion();

        }

        public void MostrarCompras()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand(" select * from cabeceracompra where estado= 'abierta'", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            /*dgvCompras.DataSource = tbl;
            dgvCompras.Columns[3].DefaultCellStyle.Format = "RD$0.00";
            dgvCompras.Columns[4].DefaultCellStyle.Format = "RD$0.00";
            dgvCompras.Columns[5].DefaultCellStyle.Format = "RD$0.00";*/

            conn.cerrarConexion();
        }

        private void dgvCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* txtnumerocompra.Text = null;
            // DataGridViewRow rellenar = dgvBuscar.Rows[e.RowIndex];
            txtidcabecera.Text = dgvCompras.CurrentRow.Cells[0].Value.ToString();
            txtnumerocompra.Text = dgvCompras.CurrentRow.Cells[1].Value.ToString();
            cbproveedor.Text = dgvCompras.CurrentRow.Cells[2].Value.ToString();
            txtSubtotal.Text = dgvCompras.CurrentRow.Cells[3].Value.ToString();
            txtItbis.Text = dgvCompras.CurrentRow.Cells[4].Value.ToString();
            txtTotal.Text = dgvCompras.CurrentRow.Cells[5].Value.ToString();
            // txtdescripcionCabecera.Text = dgvCompras.CurrentRow.Cells[6].Value.ToString();
            dtfechaEmision.Text = dgvCompras.CurrentRow.Cells[6].Value.ToString();
            cbTipoComprobante.Text = dgvCompras.CurrentRow.Cells[9].Value.ToString();
            txtcomprobante.Text = dgvCompras.CurrentRow.Cells[10].Value.ToString();
            dtfechafactura.Text = dgvCompras.CurrentRow.Cells[11].Value.ToString();
            // cbproductoCompra.Enabled = false;
            // txtdescripcionDetalle.ReadOnly = true;
            txtcantidad.ReadOnly = true;
            btnAgregardetalle.Enabled = false;
            btnEliminardetalle.Enabled = false;
            btnguardarcompra.Enabled = true;

            mostrardetalles();
            if (retornarEstadoCabecera() == "cerrada")
            {
                cbTipoComprobante.Enabled = false;
                txtnumerocompra.ReadOnly = true;
                cbproveedor.Enabled = false;
                //txtdescripcionCabecera.ReadOnly = true;
                dtfechaEmision.Enabled = false;
                dtfechafactura.Enabled = false;
                txtcomprobante.ReadOnly = true;
                txtDescuento.ReadOnly = true;
                txtItbis.ReadOnly = true;
                txtSubtotal.ReadOnly = true;
                txtTotal.ReadOnly = true;

            }*/

        }

       /* public string retornarEstadoCabecera()
        {
            string estado;
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select estado from cabeceracompra where  idcabeceracompra = @idcabecera", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idcabecera", dgvCompras.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            estado = tbl.Rows[0][0].ToString();
            conn.cerrarConexion();
            return estado;
        }*/

       /* private void txtbuscarcompra_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarcompra.Text != null)
            {
                dgvCompras.CurrentCell = null;
                foreach (DataGridViewRow r in dgvCompras.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvCompras.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscarcompra.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }

            }
            else
            {
                MostrarCompras();
            }
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("cargar nueva orden de compra?", "orden de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                cbproveedor.ResetText();
                cbtipoDocumento.ResetText();
                cbTipoComprobante.ResetText();
                txtcomprobante.Clear();
                // txtdescripcionCabecera.Clear();
                cbTipoComprobante.Text = "Tipo De Comprobante";
                txtSubtotal.Text = "0";
                txtDescuento.Text = "0";
                txtItbis.Text = "0";
                txtTotal.Text = "0";
                dgvDetalles.DataSource = null;
                cargarNumerodeCompra();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CancelarOrdenCompra();
        }

        public void CancelarOrdenCompra()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("update cabeceracompra set estado= 'cancelada'", conn.getConexion());
            cmd.ExecuteNonQuery();
            conn.cerrarConexion();
            MessageBox.Show("orden de compra cancelada!", "ORDEN DE COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
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
            SqlCommand cmd = new SqlCommand("select idproducto, producto,referencia from productos", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            dgvbuscarproducto.DataSource = tbl;
            conn.cerrarConexion();
        }

        private void dgvbuscarproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtproducto.Text = dgvbuscarproducto.CurrentRow.Cells[1].Value.ToString();
            dgvbuscarproducto.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            insertarCabecera();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.Owner = this;
            buscar.ShowDialog();
        }
    }

}