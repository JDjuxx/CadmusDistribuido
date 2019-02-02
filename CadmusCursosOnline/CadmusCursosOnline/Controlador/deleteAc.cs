using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadmusCursosOnline.Controlador
{
    class deleteAc
    {
        public void elimnateCu(int idMiem)
        {
            string cadena = "EXEC dbo.deleteMiembro1 @id = " + idMiem;
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
        }


    }
}
