using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadmusCursosOnline.Controlador
{
    class InscribirCurso
    {

        public String[] select(String Select)
        {

            String[] data = new String[4];
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = Select;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                data[0] = Convert.ToString(dr[0]);
                data[1] = Convert.ToString(dr[1]);
            }

            return data;

        }

    }
}
