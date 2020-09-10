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
    public partial class Categorias : Form
    {
        Conexion conn = new Conexion();
        int idcategoria;
        bool editar;
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
           mostrarCategorias();
        }
        public void agregarCategorias()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("existe algun campo vacio!", "CATEGORIAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

           
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("agregarcategorias", conn.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcategoria", txtidcategoria.Text);
            cmd.Parameters.AddWithValue("@categoria", txtNombre.Text);
           
            cmd.Parameters.AddWithValue("@fechacrea", dtfecha.Text);
            cmd.Parameters.AddWithValue("@usrmodifica", label3.Text);
            cmd.Parameters.AddWithValue("@estado", 1);
            cmd.ExecuteNonQuery();
            conn.cerrarConexion();
            if (txtidcategoria.Text.Length > 0)
            {
                MessageBox.Show("categoria editada correctamente!", "CATEGORIAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("categoria agregada!", "CATEGORIAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            }
        }
         public void mostrarCategorias()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select * from categorias where estado='1'",conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dgvCategorias.DataSource = tbl;
            conn.cerrarConexion();
        }
        public void eliminarCategoria()
        {
            if(MessageBox.Show("Estas seguro que quieres eliminar esta categoria?","elimiminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                conn.abrirConexion();
                idcategoria = int.Parse(dgvCategorias.CurrentRow.Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand("update categorias set estado='0' where idcategoria=@idcategoria", conn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idcategoria", idcategoria);
                cmd.ExecuteNonQuery();
                conn.cerrarConexion();

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(editar== true)
            {
                agregarCategorias();

            }
            else
            {
                agregarCategorias();

            }
            mostrarCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarCategoria();
            mostrarCategorias();
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcategoria.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            //cbTerminal.Text = dgvCategorias.CurrentRow.Cells[2].Value.ToString();
            dtfecha.Text = dgvCategorias.CurrentRow.Cells[3].Value.ToString();
        }

       
    }
}
