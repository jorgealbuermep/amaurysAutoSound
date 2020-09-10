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

namespace AmaurysAutoSong
{
    public partial class Comprobante : Form
    {
        Conexion cnn = new Conexion();
        bool editar = false;
        double secuencia;
        int cantidadCeros;
        double id;
        public Comprobante()
        {
            InitializeComponent();
        }

        private void Comprobante_Load(object sender, EventArgs e)///////// load
        {
            txtserie.Focus();
            txtsecuencia.Text = "00000000";
            mostrarComprobante();
        }

        public void agregarComprobante()
        {
            if(string.IsNullOrEmpty(txtserie.Text) || string.IsNullOrEmpty(txtsecuencia.Text) ||string.IsNullOrEmpty(txtmaximosecuencia.Text) || string.IsNullOrEmpty(txtdescripcion.Text))
            {
                MessageBox.Show("hay un campo vacio!, debe llenar todos los campos para poder guardar", "COMPROBANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            
            cnn.abrirConexion();
            SqlCommand cmd = new SqlCommand("agregarcomprobante", cnn.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcomprobante", txtidcomprobante.Text);
            cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
            cmd.Parameters.AddWithValue("@serie", txtserie.Text);
            cmd.Parameters.AddWithValue("@tipocomprobante", cbtipocomprobante.Text);
            
            cmd.Parameters.AddWithValue("@controlsecuencia", txtmaximosecuencia.Text);
            cmd.Parameters.AddWithValue("@fechavencimiento", dtfechavencimiento.Text);
            cmd.Parameters.AddWithValue("@nfc", txtsecuencia.Text);

            cmd.Parameters.AddWithValue("@estado", 1);
            


            cmd.ExecuteNonQuery();
            cnn.cerrarConexion();
            MessageBox.Show("comprobante agregado exitosamente!", "COMPROBANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void mostrarComprobante()
        {
            cnn.abrirConexion();
            SqlCommand cmd = new SqlCommand(" select * from comprobantefiscal where estado='1'", cnn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            da.Fill(tbl);
            dgvcomprobante.DataSource = tbl;
            cnn.cerrarConexion();
        }
        public  void eliminarComprobantes()
        {
            if (MessageBox.Show("estas seguro que quieres eliminar?", "COMPROBANTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                id = double.Parse(dgvcomprobante.CurrentRow.Cells[0].Value.ToString());
                cnn.abrirConexion();
                SqlCommand cmd = new SqlCommand("update comprobantefiscal set estado='0' where idcomprobante=@id", cnn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cnn.cerrarConexion();


            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtserie.Clear();
            cbtipocomprobante.Text = "Tipo De Comprobante";
            //txtsecuencia.Clear();
            txtmaximosecuencia.Clear();
            dtfechavencimiento.Text = DateTime.Now.ToShortTimeString();
            txtdescripcion.Clear();
        }

        private void cbtipocomprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
          dtfechavencimiento.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(editar== true)
            {
                agregarComprobante();

            }
            else
            {
                agregarComprobante();
            }
            mostrarComprobante();
        }

        private void dgvcomprobante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcomprobante.Text = dgvcomprobante.CurrentRow.Cells[0].Value.ToString();
            txtdescripcion.Text = dgvcomprobante.CurrentRow.Cells[1].Value.ToString();
            txtserie.Text = dgvcomprobante.CurrentRow.Cells[2].Value.ToString();
            txtmaximosecuencia.Text = dgvcomprobante.CurrentRow.Cells[3].Value.ToString();
            dtfechavencimiento.Text = dgvcomprobante.CurrentRow.Cells[4].Value.ToString();
            cbtipocomprobante.Text = dgvcomprobante.CurrentRow.Cells[5].Value.ToString();
            txtserie.Text = dgvcomprobante.CurrentRow.Cells[8].Value.ToString();





        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarComprobantes();
            mostrarComprobante();
        }
        public void generarNfc()
        {
            string cantidadCeros;
            int maximoseciencia = int.Parse(txtmaximosecuencia.Text);
            if (maximoseciencia < 10)
            {
                cantidadCeros = "0000000";
            }
            else if(maximoseciencia>=10 && maximoseciencia < 100)
            {
                cantidadCeros = "000000";
            }
            else if(maximoseciencia >= 100 && maximoseciencia < 1000)
            {
                cantidadCeros = "00000";
            }
            else if(maximoseciencia >= 1000 && maximoseciencia < 10000)
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
            else if (maximoseciencia >= 1000000 && maximoseciencia <10000000 )
            {
                cantidadCeros = "0";
            }
            else
            {
                cantidadCeros = "";
            }
            txtsecuencia.Text = maximoseciencia.ToString();
        }

        private void txtmaximosecuencia_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                generarNfc();

            }
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtfechavencimiento_ValueChanged(object sender, EventArgs e)
        {
            txtmaximosecuencia.Focus();
        }

        private void txtmaximosecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        





        /*private void btnLimpiar_Click_1(object sender, EventArgs e)
        {

        }*/

        /*  private void btnEliminar_Click_1(object sender, EventArgs e)
          {

          }*/

        /* private void btnGuardar_Click_1(object sender, EventArgs e)
         {

         }*/
    }
}
