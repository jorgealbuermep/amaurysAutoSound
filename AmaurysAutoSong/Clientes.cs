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
    public partial class Clientes : Form
    {
        int idcliente;
        bool editar=false;
        Conexion conn = new Conexion();
        public Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbterminal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)///////// load///////////
        {
            mostrarCliente();
            txtnombrecliente.Focus();
        }

        private void txtnombrecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRnc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellidocliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLimiteCredito_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbtipocliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdescripcion.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void agregarcliente()
        {
            if(string.IsNullOrEmpty(txtnombrecliente.Text) || string.IsNullOrEmpty(txtRnc.Text) || string.IsNullOrEmpty(txtTelefono.Text)  || string.IsNullOrEmpty(txtemailcliente.Text) || string.IsNullOrEmpty(txtdescripcion.Text))
            {
                MessageBox.Show("hay algun campo vacio, debe llenarlos todos para guardar", "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("agregarcliente", conn.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente", txtid.Text);
            cmd.Parameters.AddWithValue("@nombres", txtnombrecliente.Text);
            cmd.Parameters.AddWithValue("@apellidos", txtapellidocliente.Text);
            cmd.Parameters.AddWithValue("@rnc", txtRnc.Text);
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@email", txtemailcliente.Text);
           // cmd.Parameters.AddWithValue("@limitedecredito", txtLimiteCredito.Text);
            cmd.Parameters.AddWithValue("@tipocliente", cbtipocliente.Text);
            cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
           // cmd.Parameters.AddWithValue("@terminar", cbterminal.Text);
            cmd.Parameters.AddWithValue("@estado", 1);

            cmd.ExecuteNonQuery();
            conn.cerrarConexion();

            if (txtid.Text.Length > 0)
            {
                MessageBox.Show("cliente editado correctamente", " Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("cliente guardado correctamente", " Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            }
        }

        public void mostrarCliente()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select * from clientes where estado='1' ", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dgvclientes.DataSource = tbl;
            conn.cerrarConexion();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(editar== true)
            {
                agregarcliente();

            }
            else
            {
                agregarcliente();

            }
            mostrarCliente();
            txtnombrecliente.Clear();
            txtapellidocliente.Clear();
            txtRnc.Clear();
            txtTelefono.Clear();
            txtemailcliente.Clear();
            cbtipocliente.ResetText();
            txtdescripcion.Clear();
            txtnombrecliente.Focus();
        }

        public void eliminarCliente()
        {
            if(MessageBox.Show("estas seguro que quieres eliminar este cliente? ","Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                conn.abrirConexion();
                idcliente = int.Parse(dgvclientes.CurrentRow.Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand("update clientes set estado='0' where idcliente=@idcliente",conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idcliente", idcliente);
                cmd.ExecuteNonQuery();
                conn.cerrarConexion();
                mostrarCliente();
                MessageBox.Show("cliente eliminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarCliente();
            mostrarCliente();
        }

        private void dgvclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvclientes.CurrentRow.Cells[0].Value.ToString();
            txtnombrecliente.Text = dgvclientes.CurrentRow.Cells[1].Value.ToString();
            txtapellidocliente.Text = dgvclientes.CurrentRow.Cells[2].Value.ToString();
            txtRnc.Text = dgvclientes.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvclientes.CurrentRow.Cells[4].Value.ToString();
            //txtLimiteCredito.Text = dgvclientes.CurrentRow.Cells[6].Value.ToString();
            txtemailcliente.Text = dgvclientes.CurrentRow.Cells[5].Value.ToString();
            //cbterminal.Text = dgvclientes.CurrentRow.Cells[9].Value.ToString();
            cbtipocliente.Text = dgvclientes.CurrentRow.Cells[6].Value.ToString();
            txtdescripcion.Text = dgvclientes.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtnombrecliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloLetras(e);
        }

        private void txtapellidocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloLetras(e);
        }

        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void txtnombrecliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtapellidocliente.Focus();
            }
        }

        private void txtapellidocliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtRnc.Focus();
            }
        }

        private void txtRnc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtemailcliente.Focus();
            }
        }

       

        private void txtemailcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                cbtipocliente.Focus();
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != null)
            {
                dgvclientes.CurrentCell = null;
                foreach (DataGridViewRow r in dgvclientes.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvclientes.Rows)
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
            else
            {
                mostrarCliente();
            }
        }

        private void txtTelefono_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter || e.KeyCode== Keys.Tab)
            {
                txtemailcliente.Focus();
            }
        }
    }
}
