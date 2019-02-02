using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline.Controlador
{
    class MateriasImpartidas
    {
        public void cargarEst(DataGridView tabla, int idM)
        {
            string cadena = "SELECT * FROM Curso WHERE idCurso = (SELECT DISTINCT idCurso FROM Imparte WHERE idMiembro = "+idM+")";
            MessageBox.Show(cadena);
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["idCurso"].ToString(), leer["Nombre"].ToString(), leer["HORAS"].ToString(), leer["Costo"].ToString());
                }
                leer.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            conection.CerrarConexion();
        }

        public void cargarNot()
        {

        }
    }
}
