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
    public partial class principalPage : Form
    {
        Boolean flag = true;
        CargarTablas cargarTablas = new CargarTablas();

        public principalPage()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void choose_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();
            f.Show();
            f.guardarEstado(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Usted ha sido ingresado exitosamente como profesor");
            }
            else
            {

            }
        }

        private void cursosImpartidos_Click(object sender, EventArgs e)
        {
            ListaCursosImpartidos l = new ListaCursosImpartidos();
            l.Show();
            l.guardarEstado(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tablaCursos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teach_Click(object sender, EventArgs e)
        {
            cargarTablas.cargarCursoProf();
        }
    }
}
