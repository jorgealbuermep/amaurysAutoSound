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
using System.Drawing.Imaging;

namespace AmaurysAutoSong
{
    public partial class Producto : Form
    {
        Conexion conn = new Conexion();
        int idcategoria;
        bool editar = false;
        int idproducto;
        public Producto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Producto_Load(object sender, EventArgs e)  /////// load////////////
        {
            llenarcomboboxCategoria();
            mostrarProdroductos();
        }

        private void txtidproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void guardarProducto()  ////// guardar/////////
        {
            if(string.IsNullOrEmpty(cbCategoria.Text) || string.IsNullOrEmpty(cbUnidadMedida.Text)  || string.IsNullOrEmpty(cbUnidadMedida.Text)  || string.IsNullOrEmpty(txtreferencia.Text) || string.IsNullOrEmpty(txtcosto.Text) || string.IsNullOrEmpty(txtVenta.Text) || string.IsNullOrEmpty(txtdescripcion.Text)|| string.IsNullOrEmpty(txtpreciominimo.Text))
            {
                MessageBox.Show("debe llenar todos los campos!", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("agregarproducto", conn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproducto", txtidproducto.Text);
                cmd.Parameters.AddWithValue("@categoria", cbCategoria.Text );
                cmd.Parameters.AddWithValue("@nombre", txtreferencia.Text);
                cmd.Parameters.AddWithValue("@unidaddemedida", cbUnidadMedida.Text);
                cmd.Parameters.AddWithValue("@preciodeventa", txtVenta.Text);
                cmd.Parameters.AddWithValue("@preciominimo", txtpreciominimo.Text);
                cmd.Parameters.AddWithValue("@existencia", 0);
                cmd.Parameters.AddWithValue("@costo", txtcosto.Text);
               // cmd.Parameters.AddWithValue("@ultimocosto", txtultimocosto.Text);
                cmd.Parameters.AddWithValue("@fechaultimacompra", dtultimacompra.Text);
                //cmd.Parameters.AddWithValue("@codigobarra", txtcodigobarra.Text);

                cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
               // cmd.Parameters.AddWithValue("@terminar", cbterminal.Text);
                cmd.Parameters.AddWithValue("@fechacrea", dtfechacreacion.Text);
                cmd.Parameters.AddWithValue("@estado", 1);
                cmd.Parameters.AddWithValue("@itbis", txtitbis.Text);
                cmd.Parameters.AddWithValue("@referencia", txtreferencia1.Text);


                cmd.ExecuteNonQuery();

                conn.cerrarConexion();
                if (txtidproducto.Text.Length == 0)
                {
                    MessageBox.Show("producto agregado!", "PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("producto editado correctamente!", "PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }

        }

        public void mostrarProdroductos()    ////mostrar/////
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand(" select * from productos where estado='1'", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dgvproductos.DataSource = tbl;
            dgvproductos.Columns[4].DefaultCellStyle.Format = "RD$0.00";
            dgvproductos.Columns[5].DefaultCellStyle.Format = "RD$0.00";
            dgvproductos.Columns[7].DefaultCellStyle.Format = "RD$0.00";
            dgvproductos.Columns[8].DefaultCellStyle.Format = "RD$0.00";
            dgvproductos.Columns[14].DefaultCellStyle.Format = "RD$0.00";




            conn.cerrarConexion();


        }

        public int retornarIdCategoria()  /////////retornar el id de categoria////////
        {
           // conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select idcategoria  from categorias  where descripcion='" + cbCategoria.Text + "' ", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            idcategoria = int.Parse(tbl.Rows[0][0].ToString());
           // conn.cerrarConexion();
                return idcategoria;
        }

        public void eliminarProducto()  ///////////////eliminar//////////////////////
        {
            if( MessageBox.Show("¿estas seguro que quieres eliminar este producto?","PRODUCTO",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                idproducto = int.Parse(dgvproductos.CurrentRow.Cells[0].Value.ToString());
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("update productos set estado='0' where idproducto= @id", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", idproducto);
                cmd.ExecuteNonQuery();
                conn.cerrarConexion();

            }

        }

        public void llenarcomboboxCategoria()  //llenar el combobox de categorias////////////
        {

            conn.abrirConexion();
            DataTable ds= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select categoria from categorias ", conn.getConexion());
            da.Fill(ds); // paso el dataset y la vista
           cbCategoria.ValueMember = "categoria"; //////  valuemember es el nombre del campo de la vista que quiero mostrar//////

            cbCategoria.Text = "categorias";
            cbCategoria.DataSource = ds;

            conn.cerrarConexion();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(editar== true)
            {
                guardarProducto();
            }
            else
            {
                guardarProducto();
            }
            mostrarProdroductos();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cbCategoria.Text = "Categoria";
           // cbexisencia.Text = "Existencia";
           
            cbUnidadMedida.Text = "Unidad De Medida";
            txtreferencia.Clear();
            txtcosto.Clear();
            txtVenta.Clear();
            txtidproducto.Clear();
           // txtultimocosto.Clear();
            txtitbis.Clear();
            txtdescripcion.Clear();
            txtpreciominimo.Clear();
            dtfechacreacion.Text = DateTime.Now.ToShortDateString();
            dtultimacompra.Text = DateTime.Now.ToShortDateString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
            mostrarProdroductos();
        }

        private void dgvproductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidproducto.Text = dgvproductos.CurrentRow.Cells[0].Value.ToString();
            cbCategoria.Text = dgvproductos.CurrentRow.Cells[1].Value.ToString();
            cbUnidadMedida.Text = dgvproductos.CurrentRow.Cells[3].Value.ToString();
            txtVenta.Text = dgvproductos.CurrentRow.Cells[4].Value.ToString();
 // cbexisencia.Text = dgvproductos.CurrentRow.Cells[6].Value.ToString();
           // cbterminal.Text = dgvproductos.CurrentRow.Cells[12].Value.ToString();
            txtreferencia.Text = dgvproductos.CurrentRow.Cells[2].Value.ToString();
            txtcosto.Text = dgvproductos.CurrentRow.Cells[7].Value.ToString();
            txtdescripcion.Text = dgvproductos.CurrentRow.Cells[10].Value.ToString();
            txtitbis.Text = dgvproductos.CurrentRow.Cells[14].Value.ToString();


            txtpreciominimo.Text = dgvproductos.CurrentRow.Cells[5].Value.ToString();
           // txtultimocosto.Text = dgvproductos.CurrentRow.Cells[8].Value.ToString();
            dtultimacompra.Text = dgvproductos.CurrentRow.Cells[9].Value.ToString();
            dtfechacreacion.Text = dgvproductos.CurrentRow.Cells[11].Value.ToString();






        }

       /* private void txtcodigobarra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter && txtcodigobarra.Text.Length>0)
            {
                BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
                codigo.IncludeLabel = true;
                panelCodigo.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, txtcodigobarra.Text, Color.Black, Color.White,240,90);
                btnguardarcodigo.Enabled = true;
                btnguardarcodigo.Focus();
            }
        }

        private void btnguardarcodigo_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)panelCodigo.BackgroundImage.Clone();
            SaveFileDialog guardarimg = new SaveFileDialog();
            guardarimg.AddExtension = true;
            guardarimg.Filter = "Image PNG(*.png)|*.png";
            guardarimg.ShowDialog();
            if (!String.IsNullOrEmpty(guardarimg.FileName))
            {
                imgFinal.Save(guardarimg.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
            txtpreciominimo.Focus();
        }*/

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);

        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void txtpreciominimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void txtultimocosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void txtreferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtcosto.Focus();
            }
        }

        private void txtcosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtVenta.Focus();
            }
        }

        private void txtVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                calcularItbis();
                txtpreciominimo.Focus();
            }
        }

        private void txtpreciominimo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                dtultimacompra.Focus();
            }
        }

        private void txtreferencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtitbis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtpreciominimo.Focus();
            }

        }

        private void txtultimocosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                dtultimacompra.Focus();
            }
        }

        private void dtultimacompra_ValueChanged(object sender, EventArgs e)
        {
           
            
                txtdescripcion.Focus();
            
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != null)
            {
                dgvproductos.CurrentCell = null;
                foreach (DataGridViewRow r in dgvproductos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvproductos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
        }
        public void calcularItbis()
        {
            float venta = float.Parse(txtVenta.Text);
            float itbis = venta * 18 / 100;
            txtitbis.Text = itbis.ToString("0.00");

        }

       
    }
}
