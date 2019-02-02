using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadmusCursosOnline.Controlador
{
    class EliminarInscripcion
    {

        public void elimniarIns(int idCu, int idDir)
        {
            string cadena = "EXEC dbo.deleteToma @dir = " + idDir + ", @id = " + idCu + "";
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
        }
    }
}
