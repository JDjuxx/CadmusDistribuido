using CadmusCursosOnline.Controlador;
using CadmusCursosOnline.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline.Vistas
{
    public partial class ChangePas : Form
    {
        int idMiembro;
        MiembroEnt miembro = new MiembroEnt();
        ChangePass c = new ChangePass();
        principalPage page;
        public ChangePas(int idMiembro)
        {
            InitializeComponent();
            this.idMiembro = idMiembro;
        }

        public void guardarEstado(principalPage p)
        {
            page = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Dispose();
            page.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            String query = "EXEC SelectMiembro " + idMiembro;
            consultarHash(query);
            if (this.miembro.ContrasenaCorrecta(textBox1.Text))
            {
                MessageBox.Show(miembro.Salt);
                miembro.SetPassword2(textBox2.Text);
                c.cambiarPas(miembro.Contrasena, idMiembro);
                MessageBox.Show("Cambio exitoso se cerrara su cuenta por seguridad");
                new PgInicio().Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Password Incorrecta");
            }

        }
        public void consultarHash(String INSERT)
        {

            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    this.miembro.Salt = dr["Salt"].ToString();
                    this.miembro.Contrasena = dr["Contrasena"].ToString();
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            conexion.CerrarConexion();
        }
    }
}
