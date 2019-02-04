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
      
        
        
        public void cargarCursoProf(DataGridView tabla, int direccion)
        {
            string cadena = "SELECT * FROM Curso WHERE idDireccion = '"+direccion+"'";
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;    
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader leer = cmd.ExecuteReader();
                while(leer.Read())
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

        public Boolean validarProfesor(int id)
        {
            string cadena = "SELECT FormacionAcademica FROM Miembro WHERE idMiembro = '"+ id + "'";
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
                    if (leer["FormacionAcademica"].Equals("PhD"))
                    {
                        conection.CerrarConexion();
                        return true;
                    }
                }
                leer.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            conection.CerrarConexion();
            return false;
        }

        public void ingresarProfesor(int idM, int idC, int idD)
        {
            string cadena = "EXEC dbo.insertImparte @dir = "+idD+", @id = "+idM+", @ic = "+idC+", @pag = 23.45";
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("Usted ya impartio ese curso");
            }
        
        }
    }
}
