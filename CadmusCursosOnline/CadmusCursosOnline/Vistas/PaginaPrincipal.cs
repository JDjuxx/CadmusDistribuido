using CadmusCursosOnline.Controlador;
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
        public int idUsuario = 7;
        public int idDireccion = 1;
        public int idCurs = 0;
        CargarTablas ingresarProf = new CargarTablas();
  

        public principalPage()
        {
            InitializeComponent();
        }

        public void receptarDatos(int u, int d)
        {
            idUsuario = u;
            idDireccion = d;
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
            InscribirCurso inscribir = new InscribirCurso();


            int id = idCurs;
            String ingresarCurso = "INSERT INTO TOMA VALUES (" + idUsuario + "," + idCurs + ", 0)";
            inscribir.insert(ingresarCurso);
            Factura f = new Factura();
            f.Show();
            f.guardarEstado(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean flag = ingresarProf.validarProfesor(idUsuario);
            if (flag)
            {
                ingresarProf.ingresarProfesor(idUsuario , idCurs ,idDireccion);
                MessageBox.Show("Usted ha sido ingresado exitosamente como profesor");
            }
            else
            {
                MessageBox.Show("Usted no cumple con los requisitos para ser profesor, debe tener titulo Phd");
            }
        }

        private void cursosImpartidos_Click(object sender, EventArgs e)
        {
            ListaCursosImpartidos l = new ListaCursosImpartidos();
            l.ponerId(idUsuario);
            l.Show();
            l.guardarEstado(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new EliminarInscripcion().elimniarIns(idCurs, idDireccion, idUsuario);
        }

        private void tablaCursos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCurs = Int32.Parse(tablaCursos2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

        }

        private void teach_Click(object sender, EventArgs e)
        {

            ingresarProf.cargarCursoProf(tablaCursos2,idDireccion);
        }

        private void cambiarCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePas c = new ChangePas();
            c.ponerId(idUsuario);
            c.Show();
            c.guardarEstado(this);
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCurs = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }

        private void delete_Click(object sender, EventArgs e)
        {
            new deleteAc().elimnateCu(idUsuario);
            this.Dispose();
            new PgInicio().Show();
        }

        private void myAccount_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
        {
            string cadena = "SELECT * FROM Miembro WHERE idMiembro = '" + idUsuario + "'";
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
            new MisCursos().misCursos(idUsuario, dataGridView1);
            new EliminarInscripcion().elimniarIns(idCurs, idDireccion, idUsuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Nombre = textBox1.Text;
            InscribirCurso inscribir = new InscribirCurso();
            //tabla.Rows.Add(dr["idCurso"].ToString(), dr["Nombre"].ToString(), dr["HORAS"].ToString(), dr["Costo"].ToString());
            inscribir.select(tablaCursos1, "SELECT idCurso, Nombre, HORAS, Costo FROM Curso WHERE Nombre = '" + Nombre + "'");
        }

        private void tablaCursos1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCurs = Int32.Parse(tablaCursos2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

        }
    }
}
