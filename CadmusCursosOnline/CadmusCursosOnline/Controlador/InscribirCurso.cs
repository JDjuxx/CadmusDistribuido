using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline.Controlador
{
    class InscribirCurso
    {

        public void Select(DataGridView tabla,String Select)
        {

            String[] data = new String[4];
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = Select;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
       
            try
            {
                tabla.Rows.Clear();
                tabla.Refresh();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr["Nombre"].ToString(), dr["Costo"].ToString(), dr["Horas"].ToString());
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            conexion.CerrarConexion();


     
        }

        public void Insert(String Insert)
        {
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = Insert;
            cmd.ExecuteNonQuery();


        }

    }
}
