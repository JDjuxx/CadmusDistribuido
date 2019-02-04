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
    public partial class Factura : Form
    {
        principalPage page;
        int idMiembro;
        String curso;
        int idDireccion;
        decimal costo;
        
        public Factura(int idMiembro, String curso, int idDireccion, decimal costo)
        {
            InitializeComponent();
            this.idMiembro = idMiembro;
            this.curso = curso;
            this.idDireccion = idDireccion;
            this.costo = costo;
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            String query = "EXEC UltIdFac";
            int idFac = 0;
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = query;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            idFac = Convert.ToInt32(dr[0]) + 1;
            fact.Text = Convert.ToString(idFac);
            nomCurso.Text = curso;
            desc.Text = "0";
            total.Text = Convert.ToString(costo * (decimal)1.12);

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void acept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curso Ingresado con Exito, empieza cuando quieras");
            String query = "EXEC UltIdFac";
            int idFac = 0;
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            cmd.Connection = conexion.IniciarConexion();
            cmd.CommandText = query;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                idFac = Convert.ToInt32(dr[0]) + 1;
            dr.Close();
            String query2 = "EXEC insertFactura @id = " + idFac + ", @num = '" + idFac + "', @drc = '" + textBox1.Text + "', @des = 0, @tot = " + total.Text + ", @im = " + idMiembro + ", @dir = " + idDireccion;
            MessageBox.Show(query2);
            cmd.CommandText = query2;
            cmd.ExecuteNonQuery();
            String query3 = "EXEC IdCursoPorNombre @Nom = '" + curso + "'";
            cmd.CommandText = query3;
            int idCurso = 0;
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
                idCurso = Convert.ToInt32(dr1[0]);
            dr1.Close();

            String query4 = "EXEC insertfacHasCurso @dir= " + idDireccion + ", @ic =" + idCurso + ", @if = " + idFac;
            cmd.CommandText = query4;
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Factura ingresada con exito");
            this.Dispose();
            page.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            page.Show();
        }

        public void guardarEstado(principalPage p)
        {
            page = p;
        }
    }
}
