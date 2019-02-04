using CadmusCursosOnline.Controlador;
using CadmusCursosOnline.Entidades;
using CadmusCursosOnline.Vistas;
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
        MiembroEnt miembro = new MiembroEnt();

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
                String consulta = "EXEC ConsultarMiembroPorUsuuario @Us = '" + textBoxUser.Text + "'";
                String[] data = auth.Select(consulta);
                miembro.Usuario = data[0];
                miembro.Contrasena = data[1];
                miembro.IdMiembro = Convert.ToInt32(data[2]);
                miembro.IdDireccion = Convert.ToInt32(data[3]);
                miembro.Salt = data[4];
                if (miembro.ContrasenaCorrecta(password.Text))
                {
                    new Conexion().IniciarConexion();
                    new principalPage(Convert.ToInt32(data[2]), Convert.ToInt32(data[3])).Show();
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
            Registro r = new Registro();
            r.Show();
            r.guardarEstado(this);
            this.Hide();
        }
    }
}
