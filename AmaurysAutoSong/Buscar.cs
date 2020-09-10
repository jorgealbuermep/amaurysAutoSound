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
    public partial class Buscar : Form
    {
        Conexion conn = new Conexion();
       // public EventHandler<>

       public Buscar()
        {
            InitializeComponent();
        }

       

        private void Buscar_Load(object sender, EventArgs e)
        {
            MostrarCompras();
        }
        public void MostrarCompras()
        {
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand(" select * from cabeceracompra order by idcabeceracompra desc ", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dgvBuscar.DataSource = tbl;
            conn.cerrarConexion();
        }

        

       

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvBuscar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgvBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Compras cowner = (Compras)this.Owner;
            cowner.txtidcabecera.Text = dgvBuscar.CurrentRow.Cells[0].Value.ToString();
            cowner.txtnumerocompra.Text = dgvBuscar.CurrentRow.Cells[1].Value.ToString();
            cowner.cbproveedor.Text = dgvBuscar.CurrentRow.Cells[2].Value.ToString();
            cowner.txtSubtotal.Text = dgvBuscar.CurrentRow.Cells[3].Value.ToString();
            cowner.txtItbis.Text = dgvBuscar.CurrentRow.Cells[4].Value.ToString();
            cowner.txtTotal.Text = dgvBuscar.CurrentRow.Cells[5].Value.ToString();
            cowner.dtfechaEmision.Text = dgvBuscar.CurrentRow.Cells[6].Value.ToString();
            cowner.cbTipoComprobante.Text = dgvBuscar.CurrentRow.Cells[9].Value.ToString();
            cowner.txtcomprobante.Text = dgvBuscar.CurrentRow.Cells[10].Value.ToString();
            cowner.dtfechafactura.Text = dgvBuscar.CurrentRow.Cells[11].Value.ToString();
            cowner.mostrardetalles();
            // Principal p = new Principal();
            // p.Abrirform<Compras>();

            /* Compras com = new Compras();


             com.txtnumerocompra.Text = null;
            // DataGridViewRow rellenar = dgvBuscar.Rows[e.RowIndex];
             com.txtidcabecera.Text = dgvBuscar.CurrentRow.Cells[0].Value.ToString();
             com.txtnumerocompra.Text = dgvBuscar.CurrentRow.Cells[1].Value.ToString();
             com.cbproveedor.Text = dgvBuscar.CurrentRow.Cells[2].Value.ToString();
             com.txtSubtotal.Text = dgvBuscar.CurrentRow.Cells[3].Value.ToString();
             com.txtItbis.Text = dgvBuscar.CurrentRow.Cells[4].Value.ToString();
             com.txtTotal.Text = dgvBuscar.CurrentRow.Cells[5].Value.ToString();
             com.txtdescripcionCabecera.Text = dgvBuscar.CurrentRow.Cells[6].Value.ToString();
             com.dtfechaEmision.Text = dgvBuscar.CurrentRow.Cells[7].Value.ToString();
             com.cbTipoComprobante.Text = dgvBuscar.CurrentRow.Cells[10].Value.ToString();
             com.txtcomprobante.Text = dgvBuscar.CurrentRow.Cells[11].Value.ToString();
             com.dtfechafactura.Text = dgvBuscar.CurrentRow.Cells[12].Value.ToString();

              com.Show();*/

            //com.mostrardetalles();
             if (retornarEstadoCabecera() == "cerrada")
             {

                 cowner.cbTipoComprobante.Enabled = false;
                cowner. txtnumerocompra.ReadOnly = true;
                cowner.cbproveedor.Enabled = false;
               // cowner.txtdescripcionCabecera.ReadOnly = true;
                cowner.dtfechaEmision.Enabled = false;
                cowner.dtfechafactura.Enabled = false;
                cowner.txtcomprobante.ReadOnly = true;
                cowner.txtDescuento.ReadOnly = true;
                cowner.txtItbis.ReadOnly = true;
                cowner.txtSubtotal.ReadOnly = true;
                cowner.txtTotal.ReadOnly = true;
             }

             this.Visible = false;

        }
        public string retornarEstadoCabecera()
        {
            string estado;
            conn.abrirConexion();
            SqlCommand cmd = new SqlCommand("select estado from cabeceracompra where  idcabeceracompra = @idcabecera", conn.getConexion());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idcabecera", dgvBuscar.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            estado = tbl.Rows[0][0].ToString();
            conn.cerrarConexion();
            return estado;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != null)
            {
                dgvBuscar.CurrentCell = null;
                foreach (DataGridViewRow r in dgvBuscar.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvBuscar.Rows)
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
                MostrarCompras();
            }
        }
    }
}
