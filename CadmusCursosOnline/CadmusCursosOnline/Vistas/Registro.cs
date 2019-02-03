using CadmusCursosOnline.Controlador;
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

namespace CadmusCursosOnline.Vistas
{
    public partial class Registro : Form
    {
        PgInicio p;

        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Usuario = textBoxUsuario.Text;
            String Password = textBoxPassword.Text;
            String Nombre = textBoxNombre.Text;
            String Apellido = textBoxApellido.Text;
            String Nacionalidad = textBoxNacionalidad.Text;
            String FA = textBoxFA.Text;
            String DOB = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            String Direccion = comboBox1.GetItemText(comboBox1.SelectedItem);

            String bp = "SELECT TOP 1 * FROM Miembro ORDER BY idMiembro DESC ";
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = bp;
            SqlDataReader dr = cmd.ExecuteReader();
            int idMiembro = 100;
            if (dr.Read())
                idMiembro = Convert.ToInt32(dr[0]) + 1;

            RegistrarMiembro registrar = new RegistrarMiembro();
            try
            {
                registrar.insertar("EXEC dbo.insertMiembro @id = " + idMiembro + ", @us = '" + Usuario + "', @con = '" + Password + "', @salt = 'salt'," + " @cup = " + 1 + ", @nom = " + Nombre + ", @ape = " + Apellido + ", @dob = '" + DOB + "', @nac = " + Nacionalidad + ", @for = " + FA + ", @num = 0, @dir = " + Direccion);
                MessageBox.Show("Exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            this.Dispose();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Dispose();
            p.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void guardarEstado(PgInicio page)
        {
            p = page;
        }
    }


}
