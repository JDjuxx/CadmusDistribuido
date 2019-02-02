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
            new principalPage().Show();
            this.Hide();
        }
    }
}
