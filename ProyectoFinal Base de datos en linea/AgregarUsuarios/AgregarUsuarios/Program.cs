using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConexiónSQL;
namespace AgregarUsuarios
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
      // public static  Form1 F = new Form1();
        static void Main()
        {
            ParaConectar.Conectar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1 ());
        }
    }
}
