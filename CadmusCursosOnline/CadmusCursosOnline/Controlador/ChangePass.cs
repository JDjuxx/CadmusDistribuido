using CadmusCursosOnline.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline.Controlador
{
    class ChangePass
    {


        public void cambiarPas(String nps, int miemb)
        {

            String cadena = "EXEC dbo.updateMiembro @idM = " + miemb +", @con = '"+nps+"'";
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
        }

    }
}
