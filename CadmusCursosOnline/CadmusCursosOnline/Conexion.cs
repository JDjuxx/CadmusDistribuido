using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline
{
    class Conexion
    {
        SqlConnection conexion;

        public SqlConnection IniciarConexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString =
                    "Data Source=WIN-UC841MR2LRQ\\SQLpub;" +
                    "Initial Catalog=nodo1;" +
                    "User id=sa;" +
                    "Password=@dminServer123;";
            try
            {
                conexion.Open();
                //MessageBox.Show("Conexion exitosa a la base de datos");
            }
            catch (Exception)
            {
                MessageBox.Show("Error conexion a la base de datos");
            }

            return conexion;
        }

        public void CerrarConexion()
        {
            this.conexion.Close();
        }

    }

}
