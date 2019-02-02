using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline.Controlador
{
    class EliminarInscripcion
    {




        public void elimniarIns(int idCu, int idDir, int idM)
        {
            string cadena = "EXEC dbo.deleteToma1 @dir = " + idDir + ", @id = " + idM + ", @ic = "+idCu;
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Materia Eliminada");
        }
    }
}
