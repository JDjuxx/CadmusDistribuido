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
        public Boolean validarPass(string ps)
        {

            String Password = ps;

            Autenticar auth = new Autenticar();
            try
            {
                String consulta = "SELECT Usuario, Contrasena FROM Miembro WHERE Contrasena = '" + ps + "'";
                String[] data = auth.select(consulta);

                if (data[1].Equals(ps))
                {

                    return true;
                }

                else
                    MessageBox.Show("Credenciales incorrectas");
            }
            catch (Exception)
            {


            }
            return false;
        }

        public void cambiarPas(string nps, int miemb)
        {
            string cadena = "EXEC dbo.updateMiembro1 @dir = " + miemb+", @con = '"+nps+"'";
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
        }

    }
}
