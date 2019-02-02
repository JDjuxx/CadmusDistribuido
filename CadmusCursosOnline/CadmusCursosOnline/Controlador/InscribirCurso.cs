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

        public void select(DataGridView tabla,String Select)
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
                while (dr.Read())
                {
                    tabla.Rows.Add(dr["idCurso"].ToString(), dr["Nombre"].ToString(), dr["HORAS"].ToString(), dr["Costo"].ToString());
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            conexion.CerrarConexion();


     
        }

        public void insert(String Insert)
        {
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = Insert;
            cmd.ExecuteNonQuery();


        }

    }
}
