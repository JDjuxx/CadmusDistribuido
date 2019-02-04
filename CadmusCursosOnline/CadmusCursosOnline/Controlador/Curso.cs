using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadmusCursosOnline.Controlador
{
    class Curso
    {

        public String[] Select(String Select)
        {
            String[] data = new String[1];
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = Select;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //    String consulta = "SELECT Usuario, Contrasena, idMiembro, idDireccion, salt FROM Miembro WHERE Usuario = '" + Username + "'";

                data[0] = Convert.ToString(dr[0]);

              
            }
            conexion.CerrarConexion();
            return data;
        }

    }
}
