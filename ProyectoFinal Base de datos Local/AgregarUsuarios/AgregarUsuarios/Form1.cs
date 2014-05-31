using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgregarUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Delegados.cerrar = delegate
            {
                pnl_Usuarios.Controls.Clear ();
                if (Delegados.SeñalUsuarios != null)
                    Delegados.cambiarPanel();
            };

            Delegados.cambiarPanel = delegate { pnl_Usuarios.Controls.Add(Delegados.SeñalUsuarios()); };
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Usuarios.Controls.Clear();
            pnl_Usuarios.Controls.Add(new NuevoUsuario());

        }

        private void pnl_Usuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pnl_Usuarios.Controls.Clear();
            pnl_Usuarios.Controls.Add(new Buscar_usuario());
        }
    }
}
