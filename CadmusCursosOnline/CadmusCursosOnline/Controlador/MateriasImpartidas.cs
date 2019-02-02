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
            string cadena = "SELECT * FROM Curso, Imparte WHERE Curso.idCurso = Imparte.idCurso AND idMiembro = "+idM+"";
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

        public void cargarNot(int idC, DataGridView tabla)
        {
            string cadena = "SELECT Nombre, Apellido, Nota FROM Miembro, Toma WHERE Miembro.idMiembro = Toma.idMiembro AND idCurso = " + idC + "";
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
