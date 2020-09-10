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
    public partial class Principal : Form
    {
        Conexion conn = new Conexion();
        Inventario inv = new Inventario();
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
           Abrirform<Compras>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Compras))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btnCompras.BackColor = Color.Gray;
                    btnVentas.BackColor = Color.Black;
                   


                    break;
                }

            }
            /* Compras comp = new Compras();
             comp.Visible = true;*/
        }

        private void btntransacciones_Click(object sender, EventArgs e)
        {
            this.PanelMenuPrincipal.Visible = false;
            this.PanelMenuPrincipal.Dock = DockStyle.None;
            panelTransacciones.Visible = true;
            panelTransacciones.Dock = DockStyle.Left;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            /* Proveedores prov = new Proveedores();
             prov.Visible = true;*/
            Abrirform<Proveedores>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Proveedores))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btncategorias.BackColor = Color.Black;
                    btnClientes.BackColor = Color.Black;
                    btnComprobante.BackColor = Color.Black;
                    btnProductos.BackColor = Color.Black;
                    btnProveedores.BackColor = Color.Gray;
                    btnUsuarios.BackColor = Color.Black;


                    break;
                }

            }
        }

        private void btnadministracion_Click(object sender, EventArgs e)
        {
            this.PanelMenuPrincipal.Visible = false;
            this.PanelMenuPrincipal.Dock = DockStyle.None;
            panelAdministracion.Visible = true;
            panelAdministracion.Dock = DockStyle.Left;

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Abrirform<miform>() where miform : Form, new()  //////////////// abrir form
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<miform>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new miform();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)///////load//////
        {
            //this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            lblusuarioconectado.Text = InfoSistema.nombreUsuario;
            Abrirform<Inicio>();
            alertarProductosEnStok();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿estas seguro que deseas salir?", "Amaurys Auto Song", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.panelAdministracion.Dock = DockStyle.None;
            this.panelAdministracion.Visible = false;
            this.PanelMenuPrincipal.Dock = DockStyle.Left;
            this.PanelMenuPrincipal.Visible = true;

            Abrirform<Inicio>();
        }

        private void btnatras1_Click(object sender, EventArgs e)
        {
            this.panelTransacciones.Dock = DockStyle.None;
            this.panelTransacciones.Visible = false;
            this.PanelMenuPrincipal.Dock = DockStyle.Left;
            this.PanelMenuPrincipal.Visible = true;

            Abrirform<Inicio>();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Abrirform<usuarioscs>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(usuarioscs))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btncategorias.BackColor = Color.Black;
                    btnClientes.BackColor = Color.Black;
                    btnComprobante.BackColor = Color.Black;
                    btnProductos.BackColor = Color.Black;
                    btnProveedores.BackColor = Color.Black;
                    btnUsuarios.BackColor = Color.Gray;


                    break;
                }

            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Abrirform<Producto>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Producto))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btncategorias.BackColor = Color.Black;
                    btnClientes.BackColor = Color.Black;
                    btnComprobante.BackColor = Color.Black;
                    btnProductos.BackColor = Color.Gray;
                    btnProveedores.BackColor = Color.Black;
                    btnUsuarios.BackColor = Color.Black;


                    break;
                }

            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Abrirform<Clientes>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Clientes))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btncategorias.BackColor = Color.Black;
                    btnClientes.BackColor = Color.Gray;
                    btnComprobante.BackColor = Color.Black;
                    btnProductos.BackColor = Color.Black;
                    btnProveedores.BackColor = Color.Black;
                    btnUsuarios.BackColor = Color.Black;


                    break;
                }

            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Abrirform<Ventas>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Ventas))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btncategorias.BackColor = Color.Black;
                    btnClientes.BackColor = Color.Gray;
                   


                    break;
                }

            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            Abrirform<Comprobante>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Comprobante))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btncategorias.BackColor = Color.Black;
                    btnClientes.BackColor = Color.Black;
                    btnComprobante.BackColor = Color.Gray;
                    btnProductos.BackColor = Color.Black;
                    btnProveedores.BackColor = Color.Black;
                    btnUsuarios.BackColor = Color.Black;


                    break;
                }

            }
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            Abrirform<Categorias>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Categorias))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btncategorias.BackColor = Color.Gray;
                    btnClientes.BackColor = Color.Black;
                    btnComprobante.BackColor = Color.Black;
                    btnProductos.BackColor = Color.Black;
                    btnProveedores.BackColor = Color.Black;
                    btnUsuarios.BackColor = Color.Black;


                    break;
                }

            }

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Abrirform<Inventario>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Inventario))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btnadministracion.BackColor = Color.Black;
                    btntransacciones.BackColor = Color.Black;
                    btnInventario.BackColor = Color.Gray;
                    btnreportes.BackColor = Color.Black;
                    btnCerrarsesion.BackColor = Color.Black;
                   // btnUsuarios.BackColor = Color.Black;


                    break;
                }

            }

            /*  conn.abrirConexion();
              SqlCommand cmd = new SqlCommand("select producto, categoria,existencia, costo, preciodeventa from productos order by categoria", conn.getConexion());
              cmd.CommandType = CommandType.Text;
              cmd.ExecuteNonQuery();

              SqlDataAdapter da = new SqlDataAdapter(cmd);
              System.Data.DataTable tbl = new System.Data.DataTable();
              da.Fill(tbl);
              inv.dgvInventario.DataSource = tbl;
             inv. dgvInventario.Columns[3].DefaultCellStyle.Format = "RD$0.00";
             inv. dgvInventario.Columns[4].DefaultCellStyle.Format = "RD$0.00";



              conn.cerrarConexion();*/

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            Abrirform<Reportes>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Reportes))
                {
                    // MessageBox.Show("El formulario 2 esta abierto");
                    btnadministracion.BackColor = Color.Black;
                    btntransacciones.BackColor = Color.Black;
                    btnInventario.BackColor = Color.Black;
                    btnreportes.BackColor = Color.Gray;
                    btnCerrarsesion.BackColor = Color.Black;
                    // btnUsuarios.BackColor = Color.Black;


                    break;
                }

            }

        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("estas seguro que deseas cerrar sesion?","CERRAR SESION",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                
                LogIn l = new LogIn();
                this.Close();

                l.Show();
            }
        }
        public void alertarProductosEnStok()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select existencia from productos where existencia<=5 and estado=1", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            conn.cerrarConexion();
            da.Fill(tbl);
            if (tbl.Rows.Count > 0)
            {
                MessageBox.Show("tiene productos que se estan acabando, revise el inventario por favor", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
