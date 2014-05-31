using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexiónSQL;

namespace AgregarRegiones
{
    public partial class Regiones : Form
    {
        public Regiones()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            spc_Menu.Panel2.Controls.Clear();
            spc_Menu.Panel2.Controls.Add(new AgregarRegion ());
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            spc_Menu.Panel2.Controls.Clear();
            spc_Menu.Panel2.Controls.Add(new ModificarRegion());
        }

        private void Regiones_Load(object sender, EventArgs e)
        {
            ParaConectar.Conectar();
        }

    }
}
