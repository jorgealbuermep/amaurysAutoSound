using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AmaurysAutoSong;
using System.Configuration;
using AmaurysAutoSong.Properties;


namespace AmaurysAutoSong
{
    class Conexion
    {



        // SqlConnection conexion = new SqlConnection("data source=jorgepc\\SQLEXPRESS; initial catalog=amaurys;Integrated Security=True;");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["AmaurysAutoSongConnectionString"].ConnectionString);

        public void abrirConexion()
        {
           

            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public SqlConnection getConexion()
        {
            
            return conexion;
        }

        

        public bool usuarioRegistrado(string usuario)
        {
            bool resultado = false;

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("select * from usuarios where usuario= '" + usuario + "'  ", conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    resultado = true;
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }






    }
}

