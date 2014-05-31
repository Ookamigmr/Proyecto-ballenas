using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AgregarUsuarios;
using System.Windows.Forms;
using ConexiónSQL;
using Grupos;
using AgregarEspecies;
using AgregarRegiones;

namespace ProyectoBallenas
{

    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenido!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Form usuarios = new AgregarUsuarios.Form1();
            usuarios.ShowDialog();
        }

        private void btn_Especies_Click(object sender, EventArgs e)
        {
            Form especies = new AgregarEspecies.frm_Especies();
            especies.ShowDialog();
        }

        private void btn_Regiones_Click(object sender, EventArgs e)
        {
            Form regiones = new AgregarRegiones.Regiones();
            regiones.ShowDialog();
        }
    }
}
