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
    public partial class Proveedores : Form
    {
        Conexion conn = new Conexion();
        bool editar = false;
        int id;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            mostrarProveedores();
        }

        public void agregarProveedorFormal()
        {
            if (string.IsNullOrEmpty(txtnombreProveedor.Text) || string.IsNullOrEmpty(ttxrnc.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtemailproveedor.Text) || string.IsNullOrEmpty(txtdescripcion.Text))
            {
                MessageBox.Show("hay campos vacios, debe llenar todos los campos para poder guardar", "proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("agregarproveedorformal", conn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", txtidproeedor.Text);
                cmd.Parameters.AddWithValue("@nombres", txtnombreProveedor.Text);
                cmd.Parameters.AddWithValue("@rnc", ttxrnc.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@email", txtemailproveedor.Text);
                // cmd.Parameters.AddWithValue("@limitedecredito", txtLmitecredito.Text);
                cmd.Parameters.AddWithValue("@tipoproveedor", cbTipoProveedor.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                cmd.Parameters.AddWithValue("@estado", 1);

                cmd.ExecuteNonQuery();
                conn.cerrarConexion();



                MessageBox.Show("proveedor agregado!", "PROVEEDORES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }
        public void guardarproveedorinformal()
        {
            if (string.IsNullOrEmpty(txtnombreProveedor.Text) || string.IsNullOrEmpty(ttxrnc.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtemailproveedor.Text) || string.IsNullOrEmpty(txtdescripcion.Text))
            {
                MessageBox.Show("hay campos vacios, debe llenar todos los campos para poder guardar", "proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("agregarproveedorinformal", conn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", txtidproeedor.Text);
                cmd.Parameters.AddWithValue("@nombres", txtnombreProveedor.Text);
                cmd.Parameters.AddWithValue("@apellidos", txtapellidoProveedor.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@email", txtemailproveedor.Text);
                // cmd.Parameters.AddWithValue("@limitedecredito", txtLmitecredito.Text);
                cmd.Parameters.AddWithValue("@tipoproveedor", cbTipoProveedor.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                cmd.Parameters.AddWithValue("@estado", 1);


                cmd.ExecuteNonQuery();
                conn.cerrarConexion();


                MessageBox.Show("proveedor agregado!", "PROVEEDORES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }
        public void mostrarProveedores()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select * from proveedor where estado='1'", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dgvproveedores.DataSource = tbl;
            conn.cerrarConexion();
        }

        public void editarproveedorFormal()
        {
            if (MessageBox.Show("estas seguro que quieres editar este proveedor?", "PROVEEDORES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("editarproveedorformal", conn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", txtidproeedor.Text);
                cmd.Parameters.AddWithValue("@nombres", txtnombreProveedor.Text);
                cmd.Parameters.AddWithValue("@rnc", ttxrnc.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@email", txtemailproveedor.Text);
                // cmd.Parameters.AddWithValue("@limitedecredito", txtLmitecredito.Text);
                cmd.Parameters.AddWithValue("@tipoproveedor", cbTipoProveedor.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                cmd.Parameters.AddWithValue("@estado", 1);
                cmd.ExecuteNonQuery();
                conn.cerrarConexion();
                MessageBox.Show("proveedor editado correctamente!", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void editarproveedorInformal()
        {
            if (MessageBox.Show("estas seguro que quieres editar este proveedor?", "PROVEEDORES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("editarproveedorformal", conn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", txtidproeedor.Text);
                cmd.Parameters.AddWithValue("@nombres", txtnombreProveedor.Text);
                cmd.Parameters.AddWithValue("@apellidos", txtapellidoProveedor.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@email", txtemailproveedor.Text);
                // cmd.Parameters.AddWithValue("@limitedecredito", txtLmitecredito.Text);
                cmd.Parameters.AddWithValue("@tipoproveedor", cbTipoProveedor.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                cmd.Parameters.AddWithValue("@estado", 1);


            }
        }





        private void txtapellidoProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblapellido_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (cbTipoProveedor.Text == "Formal" && txtidproeedor.Text.Length == 0)
            {
                agregarProveedorFormal();

            }
            else if (cbTipoProveedor.Text == "Formal" && txtidproeedor.Text.Length > 0)
            {
                editarproveedorFormal();
            }
            else if (cbTipoProveedor.Text == "Informal" && txtidproeedor.Text.Length == 0)
            {
                guardarproveedorinformal();

            }
            else if (cbTipoProveedor.Text == "Informal" && txtidproeedor.Text.Length > 0)
            {
                editarproveedorInformal();
            }

            mostrarProveedores();
        }

        private void cbTipoProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoProveedor.Text == "Formal")
            {
                lblapellido.Enabled = false;
                txtapellidoProveedor.Enabled = false;
                txtnombreProveedor.Focus();
                lblrnc.Enabled = true;
                ttxrnc.Enabled = true;
                txtnombreProveedor.Focus();
            }
            else
            {
                lblapellido.Enabled = true;
                txtapellidoProveedor.Enabled = true;
                lblrnc.Enabled = false;
                ttxrnc.Enabled = false;
                txtnombreProveedor.Focus();

            }
        }

        private void dgvproveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvproveedores.CurrentRow.Cells[7].Value.ToString() == "Formal")
            {
                txtidproeedor.Text = dgvproveedores.CurrentRow.Cells[0].Value.ToString();
                txtnombreProveedor.Text = dgvproveedores.CurrentRow.Cells[1].Value.ToString();
                txtapellidoProveedor.Text = dgvproveedores.CurrentRow.Cells[2].Value.ToString();
                ttxrnc.Text = dgvproveedores.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgvproveedores.CurrentRow.Cells[4].Value.ToString();
                txtemailproveedor.Text = dgvproveedores.CurrentRow.Cells[5].Value.ToString();
                // txtLmitecredito.Text = dgvproveedores.CurrentRow.Cells[6].Value.ToString();
                cbTipoProveedor.Text = dgvproveedores.CurrentRow.Cells[6].Value.ToString();
                txtdescripcion.Text = dgvproveedores.CurrentRow.Cells[7].Value.ToString();

            }
            else
            {
                txtidproeedor.Text = dgvproveedores.CurrentRow.Cells[0].Value.ToString();
                txtnombreProveedor.Text = dgvproveedores.CurrentRow.Cells[1].Value.ToString();
                txtapellidoProveedor.Text = dgvproveedores.CurrentRow.Cells[2].Value.ToString();
                 ttxrnc.Text = dgvproveedores.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgvproveedores.CurrentRow.Cells[4].Value.ToString();
                txtemailproveedor.Text = dgvproveedores.CurrentRow.Cells[5].Value.ToString();
                // txtLmitecredito.Text = dgvproveedores.CurrentRow.Cells[6].Value.ToString();
                cbTipoProveedor.Text = dgvproveedores.CurrentRow.Cells[6].Value.ToString();
                txtdescripcion.Text = dgvproveedores.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtidproeedor.Clear();
            cbTipoProveedor.Text = "Tipo De Proveedor";
            txtnombreProveedor.Clear();
            txtapellidoProveedor.Clear();
            ttxrnc.Clear();
            txtTelefono.Clear();
            txtemailproveedor.Clear();
            // txtLmitecredito.Clear();
            txtdescripcion.Clear();
        }

        public void eliminarproveedor()
        {
            if (MessageBox.Show("estas seguro que quieres eliminar este proveedor?", "PROVEEDORES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.abrirConexion();
                id = int.Parse(dgvproveedores.CurrentRow.Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand("update proveedor set estado='0' where idproveedor=@idproveedor", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idproveedor", id);
                cmd.ExecuteNonQuery();
                conn.cerrarConexion();
                MessageBox.Show("proveedor eliminado correctamente!", "PROVEEDORES", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarproveedor();
            mostrarProveedores();
        }

        private void txtLmitecredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void txtnombreProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (txtapellidoProveedor.Enabled == true)
                {
                    txtapellidoProveedor.Focus();
                }
                else
                {
                    ttxrnc.Focus();
                }
            }
        }

        private void ttxrnc_KeyDown(object sender, KeyEventArgs e)
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
                txtemailproveedor.Focus();
            }
        }

        private void txtemailproveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtdescripcion.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != null)
            {
                dgvproveedores.CurrentCell = null;
                foreach (DataGridViewRow r in dgvproveedores.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvproveedores.Rows)
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
    }
}
