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
    public partial class Calificar : Form
    {
        ListaCursosImpartidos page;
        public Calificar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            page.Show();
            this.Dispose();
        }

        public void guardarEstado(ListaCursosImpartidos p)
        {
            page = p;
        }
    }
}
