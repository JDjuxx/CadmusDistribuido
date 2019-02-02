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

namespace CadmusCursosOnline
{
    public partial class ListaCursosImpartidos : Form
    {
        MateriasImpartidas m = new MateriasImpartidas();
        principalPage page;
        public int idM = 0;
        public int idC = 0;
        public ListaCursosImpartidos()
        {
            InitializeComponent();
            
        }

        public void ponerId(int id)
        {
            idM = id;
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

        private void ListaCursosImpartidos_Load(object sender, EventArgs e)
        {
            m.cargarEst(cursosImpartidos, idM);
            
        }

        private void cursosImpartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            m.cargarNot(Int32.Parse(cursosImpartidos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()),estudianteCurso);
        }
    }
}
