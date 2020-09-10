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
    public partial class LogIn : Form
    {
        Conexion conn = new Conexion();
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            usuarioscs u = new usuarioscs();
            if (u.EsTextoVálido(txtpass.Text))
            {


                /* Principal principal = new Principal();
                 this.Visible = false;
                 principal.Visible = true;*/

                if (validarlogIn())
                {
                    Principal p = new Principal();
                    this.Visible = false;
                    p.Visible = true;

                    if (InfoSistema.fusuarios != "1")
                    {
                        p.btnUsuarios.Enabled = false;

                    }

                    if (InfoSistema.fclientes != "1")
                    {
                        p.btnClientes.Enabled = false;

                    }
                    if (InfoSistema.fproveedores != "1")
                    {
                        p.btnProveedores.Enabled = false;

                    }
                    if (InfoSistema.fcomprobantes != "1")
                    {
                        p.btnComprobante.Enabled = false;

                    }

                    if (InfoSistema.fcompras != "1")
                    {
                        p.btnCompras.Enabled = false;

                    }

                    if (InfoSistema.fventas != "1")
                    {
                        p.btnVentas.Enabled = false;

                    }

                    if (InfoSistema.finventario != "1")
                    {
                        p.btnInventario.Enabled = false;

                    }

                    if (InfoSistema.freportes != "1")
                    {
                        p.btnreportes.Enabled = false;

                    }
                    if (InfoSistema.fcategorias != "1")
                    {
                        p.btncategorias.Enabled = false;

                    }
                    if (InfoSistema.fproductos != "1")
                    {
                        p.btnProductos.Enabled = false;

                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta!", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }

        public bool validarlogIn()    /////////////////////////////validarlogin
        {


            //string consulta;
            //this.codigo = txtuserlogin.Text;
            //Infosistema.nombreUsuario = txtuserlogin.Text;


            bool resultado = false;
            try
            {

                usuarioscs u = new usuarioscs();
             
                conn.abrirConexion();
                Principal fp = new Principal();
               // DefinicionMetas df = new DefinicionMetas();
                SqlCommand cmdLogIn = new SqlCommand("select * from usuarios as a inner join accesos as b on(b.idacceso= a.idacceso) where a.usuario= @user and  a.pass=@pass", conn.getConexion());
                cmdLogIn.CommandType = CommandType.Text;
               
                    cmdLogIn.Parameters.AddWithValue("@user", txtusuario.Text);
                    cmdLogIn.Parameters.AddWithValue("@pass", txtpass.Text);
                

                
                SqlDataReader dr = cmdLogIn.ExecuteReader();



                if (dr.Read())
                {
                    //Infosistema.nombreUsuario = txtuserlogin.Text;


                    InfoSistema.fusuarios = dr[8].ToString();
                    InfoSistema.fclientes = dr[9].ToString();
                    InfoSistema.fproveedores = dr[10].ToString();
                    InfoSistema.fcomprobantes = dr[11].ToString();
                    InfoSistema.fcompras = dr[12].ToString();
                    InfoSistema.fventas = dr[13].ToString();
                    InfoSistema.finventario = dr[14].ToString();
                    InfoSistema.freportes = dr[15].ToString();
                    InfoSistema.fcategorias = dr[16].ToString();
                    InfoSistema.fproductos = dr[17].ToString();
                    InfoSistema.nombreUsuario = txtusuario.Text;







                    resultado = true;


                }
                dr.Close();
                conn.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {if(MessageBox.Show("¿Estas seguro que quieres salir?","Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            Application.Exit();
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                btnIniciar.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
