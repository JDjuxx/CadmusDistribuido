using CadmusCursosOnline.Controlador;
using CadmusCursosOnline.Entidades;
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

        MiembroEnt miembro = new MiembroEnt();
        CursoEnt curso = new CursoEnt();
        MateriasImpartidas m;
        principalPage page;
        public ListaCursosImpartidos(int idMiembro)
        {
            InitializeComponent();
            miembro.IdMiembro = idMiembro;
           m = new MateriasImpartidas();
            m.CargarMaterias(cursosImpartidos, miembro.IdMiembro);
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


        private void cursosImpartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           // m.cargarNot(Int32.Parse(cursosImpartidos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()),estudianteCurso);
        }

        private void cursosImpartidos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                curso.IdCurso = Convert.ToInt32(cursosImpartidos.Rows[e.RowIndex].Cells[0].Value.ToString());
                m.cargarNot(curso.IdCurso, estudianteCurso);

                
            }
            catch (Exception)
            {
               
             }
        }
    }
}
