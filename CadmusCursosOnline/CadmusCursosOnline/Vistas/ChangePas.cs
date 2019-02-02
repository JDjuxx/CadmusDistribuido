using CadmusCursosOnline.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline.Vistas
{
    public partial class ChangePas : Form
    {

        ChangePass c = new ChangePass();
        principalPage page;
        public int miemb = 0;
        public ChangePas()
        {
            InitializeComponent();
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

        public void ponerId(int id)
        {
            miemb = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.validarPass(textBox1.Text))
            {
                c.cambiarPas(textBox2.Text, miemb);
                MessageBox.Show("Cambio exitoso se cerrara su cuenta por seguridad");
                new PgInicio().Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Ingrese bien su password");
            }

        }
    }
}
