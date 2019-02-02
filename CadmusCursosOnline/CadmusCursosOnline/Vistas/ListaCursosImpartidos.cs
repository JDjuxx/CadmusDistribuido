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
    public partial class ListaCursosImpartidos : Form
    {
        principalPage page;
        public ListaCursosImpartidos()
        {
            InitializeComponent();
            
        }

        private void volver_Click(object sender, EventArgs e)
        {

            this.Dispose();
            page.Show();
        }

        public void guardarEstado(principalPage p)
        {
            page = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calificar c = new Calificar();
            c.Show();
            c.guardarEstado(this);
            this.Hide();
        }
    }
}
