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
using System.Text.RegularExpressions;

namespace AmaurysAutoSong
{
    public partial class usuarioscs : Form
    {
        int idacceso;
        int idusuario;
        bool editar = false;
        Conexion conn = new Conexion();
        public usuarioscs()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e) //boton agregar
        {
            if (editar == true)
            {
                agregaracceso();
                agregarusuarios();
                txtnombre.Clear();
                txtapellido.Clear();
                txtpass.Clear();
                txtusuario.Clear();
                chUsuarios.Checked = false;
                chproveedores.Checked = false;
                chProductos.Checked = false;
                chCategorias.Checked = false;
              //  MessageBox.Show("Usuario añadido", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregaracceso();
                agregarusuarios();
              //  mostrarusuario();
                txtnombre.Clear();
                txtapellido.Clear();
                txtpass.Clear();
                txtusuario.Clear();
               // MessageBox.Show("Usuario añadido", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            mostrarusuario();

        }

        private void dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void agregarusuarios()
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text) || string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtpass.Text) || string.IsNullOrEmpty(txtconfirmarPass.Text))
            {
                MessageBox.Show("hay campos vacios, debe llenarlos todos para poder guardar", "USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("agregarusuario", conn.getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", txtid.Text);
                cmd.Parameters.AddWithValue(@"nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@apellido", txtapellido.Text);
                cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
                cmd.Parameters.AddWithValue("@pass", txtpass.Text);
                cmd.Parameters.AddWithValue("@idacceso", retornaridacceso());
                cmd.Parameters.AddWithValue("estado", 1);
                cmd.ExecuteNonQuery();
                conn.cerrarConexion();
                if (txtid.Text.Length > 0)
                {
                    MessageBox.Show("usuario editado correctamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("usuario guardado correctamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }
        public int retornaridacceso()
        {
            SqlCommand cmd = new SqlCommand("select max(idacceso) from accesos", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            idacceso = int.Parse(tbl.Rows[0][0].ToString());
            return idacceso;

        }

        public void mostrarusuario()
        {
            conn.abrirConexion();
            SqlCommand mostrar = new SqlCommand("select *from usuarios as a inner join accesos as b on(a.idacceso=b.idacceso) where a.estado=1  ", conn.getConexion());
            mostrar.CommandType = CommandType.Text;
            mostrar.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(mostrar);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dgvusuarios.DataSource = tbl;
            conn.cerrarConexion();
        }

        public void agregaracceso()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("agregaracceso", conn.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idacceso", txtid.Text);
            cmd.Parameters.AddWithValue("@usuarios", chUsuarios.Checked);
            cmd.Parameters.AddWithValue("@clientes", chClientes.Checked);
            cmd.Parameters.AddWithValue("@proveedores", chproveedores.Checked);
            cmd.Parameters.AddWithValue("@comprobantes", chComprobantes.Checked);
            cmd.Parameters.AddWithValue("@compras", chCompas.Checked);
            cmd.Parameters.AddWithValue("@ventas", chVentas.Checked);
            cmd.Parameters.AddWithValue("@inventario", chInventario.Checked);
            cmd.Parameters.AddWithValue("@reportes", chReportes.Checked);
            cmd.Parameters.AddWithValue("@categorias", chCategorias.Checked);
            cmd.Parameters.AddWithValue("@productos", chProductos.Checked);

            cmd.ExecuteNonQuery();

            conn.cerrarConexion();


        }

        public void btn2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quiere eliminar el usuario?","ALERTAROJA",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                idusuario = int.Parse(dgvusuarios.CurrentRow.Cells[0].Value.ToString());
                conn.abrirConexion();
                SqlCommand cmd = new SqlCommand("update usuarios set estado = '0' where idusuario = @idusuario", conn.getConexion());
                cmd.Parameters.AddWithValue("@idusuario", idusuario);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.cerrarConexion();
                MessageBox.Show("usuario eliminado");
                mostrarusuario();
            }
        }


        private void usuarioscs_Load(object sender, EventArgs e)
        {
            mostrarusuario();
        }

        private void dgvusuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.Text = dgvusuarios.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvusuarios.CurrentRow.Cells[2].Value.ToString();
            txtpass.Text = dgvusuarios.CurrentRow.Cells[3].Value.ToString();
            txtusuario.Text = dgvusuarios.CurrentRow.Cells[4].Value.ToString();
            txtid.Text = dgvusuarios.CurrentRow.Cells[0].Value.ToString();
        }

        public  bool EsTextoVálido(string texto)
        {
            var r = new Regex(@"^(?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9])\S{5,10}$");
            return r.Match(texto).Success ? true : false;
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)  //////txtpass
        {
            if(e.KeyCode== Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (EsTextoVálido(txtpass.Text))
                {
                    txtconfirmarPass.Focus();

                }
                else
                {
                    MessageBox.Show("la contraseña debe tener por lo menos una letra mayuscula, un numero y un minimo de 5 letras!", "USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpass.Clear();
                    txtpass.Focus();

                }

            }
        }

        private void txtconfirmarPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if(txtpass.Text != txtconfirmarPass.Text)
                {
                    MessageBox.Show("las contraseñas no concuerdan", "USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtconfirmarPass.Clear();
                    txtconfirmarPass.Focus();
                }
                else
                {
                    chUsuarios.Focus();
                }
            }
        }

        private void dgvusuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }

        }

        private void txtbuscaruser_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscaruser.Text != null)
            {
                dgvusuarios.CurrentCell = null;
                foreach (DataGridViewRow r in dgvusuarios.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvusuarios.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscaruser.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }

            }
            else
            {
                mostrarusuario();
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter || e.KeyCode== Keys.Tab)
            {
                txtapellido.Focus();
            }
        }

        private void txtapellido_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtusuario.Focus();
            }
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtpass.Focus();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int iduser;
            if (MessageBox.Show("estas seguro que quieres eliminar este usuario? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.abrirConexion();
                iduser = int.Parse(dgvusuarios.CurrentRow.Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand("update usuarios set estado='0' where idusuario=@iduser", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@iduser", iduser);
                cmd.ExecuteNonQuery();
                conn.cerrarConexion();
                mostrarusuario();
                MessageBox.Show("usuario eliminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }

       
    }
}
