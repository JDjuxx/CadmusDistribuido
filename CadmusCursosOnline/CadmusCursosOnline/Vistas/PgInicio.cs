using CadmusCursosOnline.Controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline
{
    public partial class PgInicio : Form
    {
        public PgInicio()
        {
            InitializeComponent();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            //Autenticacion
            String Username = textBoxUser.Text;
            String Password = password.Text;

            Autenticar auth = new Autenticar();
            try
            {
                String consulta = "SELECT Usuario, Contrasena FROM Miembro WHERE Usuario = '" + Username + "'";
                String[] data = auth.select(consulta);

                if (data[1].Equals(password.Text))
                {

                    new Conexion().IniciarConexion();
                    new principalPage().Show();
                    this.Hide();
                }

                else
                    MessageBox.Show("Credenciales incorrectas");
            }
            catch (Exception)
            {

             
            }
           



        }

        private void registrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //new Regi
        }
    }
}
