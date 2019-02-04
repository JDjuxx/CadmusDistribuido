using CadmusCursosOnline.Controlador;
using CadmusCursosOnline.Entidades;
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
        MiembroEnt miembro = new MiembroEnt();


        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            miembro.Usuario = textBoxUsuario.Text;
            miembro.SetPassword(textBoxPassword.Text);
            miembro.Nombre = textBoxNombre.Text;
            miembro.Apellido = textBoxApellido.Text;
            miembro.Nacionalidad = comboBox2.GetItemText(comboBox2.SelectedItem);
            miembro.FormacionA = comboBox3.GetItemText(comboBox3.SelectedItem);
            miembro.DOB = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            String sucursal = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (sucursal.Equals("Estados Unidos"))
                miembro.IdDireccion = 1;
            else
                miembro.IdDireccion = 2;
      
            String bp = "EXEC UltIdMie";
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = bp;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                miembro.IdMiembro = Convert.ToInt32(dr[0]) + 1;

            RegistrarMiembro registrar = new RegistrarMiembro();
            try
            {
                String query = "EXEC dbo.insertMiembro @id = " + miembro.IdMiembro + ", @us = '" + miembro.Usuario + "', @con = '" + miembro.Contrasena + "', @salt = '" + miembro.Salt + "', @cup = " + miembro.CupoCurGrat + ", @nom = " + miembro.Nombre + ", @ape = " + miembro.Apellido + ", @dob = '" + miembro.DOB + "', @nac = " + miembro.Nacionalidad + ", @for = '" + miembro.FormacionA + "', @num = 0, @dir = " + miembro.IdDireccion;
                registrar.insertar("EXEC dbo.insertMiembro @id = " + miembro.IdMiembro + ", @us = '" + miembro.Usuario + "', @con = '" + miembro.Contrasena + "', @salt = '" + miembro.Salt + "', @cup = " + miembro.CupoCurGrat + ", @nom = " + miembro.Nombre + ", @ape = " + miembro.Apellido + ", @dob = '" + miembro.DOB + "', @nac = " + miembro.Nacionalidad + ", @for = " + miembro.FormacionA + ", @num = 0, @dir = " + miembro.IdDireccion);
                MessageBox.Show("Exito");
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
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
