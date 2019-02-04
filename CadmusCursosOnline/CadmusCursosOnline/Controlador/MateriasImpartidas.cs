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
        public String CargarMaterias(DataGridView tabla, int idM)
        {
            string cadena = "EXEC CursoImparteMiembro " + idM;
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            SqlDataReader leer = cmd.ExecuteReader();
            String idCurso= "";
            try
            {
                
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
            return idCurso;
        }

        public void cargarNot(int idC, DataGridView tabla)
        {
            string cadena = "EXEC miembroTomaCurso @idCur = " + idC;
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
                    tabla.Rows.Add(leer["Nombre"].ToString(), leer["Apellido"].ToString(), leer["Nota"].ToString());
                }
                leer.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            conection.CerrarConexion();
        }
    }
}
