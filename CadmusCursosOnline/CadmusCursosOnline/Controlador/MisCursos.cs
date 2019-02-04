using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline.Controlador
{
    class MisCursos
    {
        public void misCursos(int idm, DataGridView tabla)
        {
            string cadena = "EXEC CursoTomaMiembro " + idm + "";
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            tabla.Rows.Clear();
            tabla.Refresh();
            try
            {
                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["idCurso"], leer["Nombre"].ToString(), leer["Nota"].ToString());
                }
                leer.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            conection.CerrarConexion();
        }

        public void misCursosNombre(int idm, String nomCur, DataGridView tabla)
        {
            string cadena = "EXEC CursoTomaMiembroNomCurso " + idm + ", " + nomCur;
            MessageBox.Show(cadena);
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
      
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataReader leer = cmd.ExecuteReader();
                tabla.Rows.Clear();
                tabla.Refresh();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["idCurso"], leer["Nombre"].ToString(), leer["Nota"].ToString());
                }
                leer.Close();
            }
            catch (SqlException e)
            {
             
            }
            conection.CerrarConexion();
        }

        public void borrarMiCurso(int idm, int idCur, int idDir, DataGridView tabla)
        {
            string cadena = "EXEC deleteToma " + idm + ", " + idDir + ", " + idCur;
            MessageBox.Show(cadena);
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataReader leer = cmd.ExecuteReader();
                tabla.Rows.Clear();
                tabla.Refresh();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["Nombre"].ToString(), leer["Nota"].ToString());
                }
                leer.Close();
            }
            catch (SqlException e)
            {

            }
            conection.CerrarConexion();
        }

    }
}
