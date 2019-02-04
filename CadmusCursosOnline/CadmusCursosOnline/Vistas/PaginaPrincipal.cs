using CadmusCursosOnline.Controlador;
using CadmusCursosOnline.Entidades;
using CadmusCursosOnline.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline
{
    public partial class principalPage : Form
    {

        MiembroEnt miembro;
        CursoEnt curso = new CursoEnt();

        CargarTablas ingresarProf = new CargarTablas();

        public principalPage(int IdMiembro, int IdDireccion)
        {
            InitializeComponent();
            this.miembro = new MiembroEnt(IdMiembro, IdDireccion);
        }

        public principalPage()
        {
            InitializeComponent();
        }

       /*public void receptarDatos(int u, int d)
        {
            idUsuario = u;
            idDireccion = d;
        }*/

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
            String query = "EXEC IdCursoPorNombre @Nom = '" + tablaCursos1.CurrentRow.Cells[0].Value.ToString() + "'";
            Curso Curso = new Curso();
            String[] data = Curso.Select(query);
            curso.IdCurso = Convert.ToInt32(data[0]);


            InscribirCurso inscribir = new InscribirCurso();
            String ingresarCurso = "EXEC insertToma @dir = " + miembro.IdDireccion + ", @id = " + miembro.IdMiembro + ", @ic = " + curso.IdCurso + ", @not = 0";
            inscribir.Insert(ingresarCurso);
            inscribir.Select(tablaCursos1, "EXEC CursoNoTomaMiembro @idM = " + miembro.IdMiembro + ", @idDir = " + miembro.IdDireccion);
            
            String query2 = "EXEC SelectCurso " + curso.IdCurso;
            String[] datosFact = new String[2];
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = query2;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                datosFact[0] = Convert.ToString(dr["Nombre"]);
                datosFact[1] = Convert.ToString(dr["Costo"]);

            }
            conexion.CerrarConexion();

            curso.Nombre = datosFact[0];
            curso.Costo = Convert.ToDecimal(datosFact[1]);


            Factura f = new Factura(miembro.IdMiembro, curso.Nombre,miembro.IdDireccion,curso.Costo);
            f.Show();
            f.guardarEstado(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean flag = ingresarProf.validarProfesor(miembro.IdMiembro);
            flag = true;
            if (flag)
            {
                SqlCommand cmd = new SqlCommand();
                String query3 = "EXEC IdCursoPorNombre @Nom = '" + tablaCursos2.SelectedCells[0] + "'";
                cmd.CommandText = query3;
                int idCurso = 0;
                Conexion con = new Conexion();
                cmd.Connection = con.IniciarConexion();
                SqlDataReader dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                    idCurso = Convert.ToInt32(dr1[0]);
                dr1.Close();
                ingresarProf.ingresarProfesor(miembro.IdMiembro , curso.IdCurso ,miembro.IdDireccion);
                MessageBox.Show("Usted ha sido ingresado exitosamente como profesor");
                InscribirCurso inscribir = new InscribirCurso();
                String query = "EXEC CursoNotImparteMiembro @idM = " + miembro.IdMiembro + ", @idDir = " + miembro.IdDireccion;
                MessageBox.Show(query);
                inscribir.Select(tablaCursos2, query);
            }
            else
            {
                MessageBox.Show("Usted no cumple con los requisitos para ser profesor, debe tener titulo Phd");
            }
        }

        private void cursosImpartidos_Click(object sender, EventArgs e)
        {
            ListaCursosImpartidos l = new ListaCursosImpartidos(miembro.IdMiembro);
            l.Show();
            l.guardarEstado(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            curso.IdCurso = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            MisCursos cursos = new MisCursos();
            cursos.borrarMiCurso(miembro.IdMiembro, curso.IdCurso, miembro.IdDireccion, dataGridView1);
            cursos.misCursos(miembro.IdMiembro, dataGridView1);

        }

        private void tablaCursos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //idCurso = Int32.Parse(tablaCursos2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

        }

        private void teach_Click(object sender, EventArgs e)
        {

        }

        private void cambiarCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePas c = new ChangePas(miembro.IdMiembro);
            c.Show();
            c.guardarEstado(this);
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //idCurso = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }

        private void delete_Click(object sender, EventArgs e)
        {
            new DeletMiembro().elimnateCu(miembro.IdMiembro);
            this.Dispose();
            new PgInicio().Show();
        }

        private void myAccount_Click(object sender, EventArgs e)
        {
            
        }

        public void cargarDatos()
        {
            String cadena = "EXEC SelectMiembro " + miembro.IdMiembro;
            SqlCommand cmd = new SqlCommand();
            Conexion conection = new Conexion();
            cmd.Connection = conection.IniciarConexion();
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    usern.Text = leer["Usuario"].ToString();
                    name.Text = leer["Nombre"].ToString();
                    apellido.Text = leer["Apellido"].ToString();
                    cuprest.Text = leer["CupoCurGrat"].ToString();
                    dob.Text = leer["DOB"].ToString();
                    nac.Text = leer["Nacionalidad"].ToString();
                    formAcad.Text = leer["FormacionAcademica"].ToString();
                }

                leer.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            conection.CerrarConexion();

            
        }

        private void myCurses_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            curso.Nombre = textBox1.Text;
            InscribirCurso inscribir = new InscribirCurso();

            try
            {
                inscribir.Select(tablaCursos1, "EXEC CursoNoTomaMiembroNombre @idM = " + miembro.IdMiembro + ", @Nom = '" + curso.Nombre + "', @idDir = " + miembro.IdDireccion);
            }
            catch (Exception)
            {

            }
           
        }

        private void buscarCurProf_Click(object sender, EventArgs e)
        {

            curso.Nombre = textBox2.Text;
            String query = "EXEC CursoNotImparteMiembroNombre @idM = " + miembro.IdMiembro + ", @idDir = " + miembro.IdDireccion + ", @Nom = '" + curso.Nombre + "'";
            InscribirCurso inscribir = new InscribirCurso();
            inscribir.Select(tablaCursos2, query);
        }

        private void inscription_Enter(object sender, EventArgs e)
        {
            InscribirCurso inscribir = new InscribirCurso();
            inscribir.Select(tablaCursos1, "EXEC CursoNoTomaMiembro @idM = " + miembro.IdMiembro + ", @idDir = " + miembro.IdDireccion);
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
        }

        private void teach_Enter(object sender, EventArgs e)
        {
            InscribirCurso inscribir = new InscribirCurso();
            String query = "EXEC CursoNotImparteMiembro @idM = " + miembro.IdMiembro + ", @idDir = " + miembro.IdDireccion;
            MessageBox.Show(query);
            inscribir.Select(tablaCursos2, query);

        }

        private void tablaCursos1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaCursos1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Curso Curso = new Curso();
            try
            {
                String query = "EXEC IdCursoPorNombre @Nom = '" + tablaCursos1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "'";
                String[] data = Curso.Select(query);
                curso.IdCurso = Convert.ToInt32(data[0]);
            }
            catch (Exception)
            {

            }
            
        }

        private void tablaCursos1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void myCurses_Enter(object sender, EventArgs e)
        {
            MisCursos curso = new MisCursos();
            curso.misCursos(miembro.IdMiembro, dataGridView1);
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MisCursos curso = new MisCursos();
            this.curso.Nombre = textBox3.Text;
            curso.misCursosNombre(miembro.IdMiembro, this.curso.Nombre, dataGridView1);
        }

        private void myAccount_Enter(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
