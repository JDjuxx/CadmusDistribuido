using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadmusCursosOnline.Controlador
{
    class RegistrarMiembro
    {
        public void insertar(String INSERT)
        {

            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
                 
        }

    }
}
