using System;
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
    public partial class Factura : Form
    {
        principalPage page;

        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void acept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curso Ingresado con Exito, empieza cuando quieras");
            this.Dispose();
            page.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            page.Show();
        }

        public void guardarEstado(principalPage p)
        {
            page = p;
        }
    }
}
