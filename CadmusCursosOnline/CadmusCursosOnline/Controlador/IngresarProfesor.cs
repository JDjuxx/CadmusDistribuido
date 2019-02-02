using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadmusCursosOnline
{
    class CargarTablas
    {
      
        
        
        public void cargarCursoProf(DataGridView tabla)
        {
            String[] values = new String[4]; 
            string cadena = "SELECT * FROM Curso01";
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    values[0] = leer["idCurso"].ToString();
                    values[1] = leer["Nombre"].ToString();
                    values[2] = leer["Costo"].ToString();
                    values[3] = leer["HORAS"].ToString();
                    leer.Close();
                }
                

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }


        }
    }
}
