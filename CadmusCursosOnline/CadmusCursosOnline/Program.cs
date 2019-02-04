using CadmusCursosOnline.Controlador;
using CadmusCursosOnline.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmusCursosOnline
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Conexion conexion = new Conexion();
            //conexion.IniciarConexion();
            // Application.Run(new principalPage());
            Application.Run(new PgInicio());            
        }
    }
}
