using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexiónSQL;

namespace AgregarEspecies
{
    public partial class frm_Especies : Form
    {
        public frm_Especies()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            spc_Menu.Panel2.Controls.Clear();
            spc_Menu.Panel2.Controls.Add(new AgregarEspecie());
        }

        private void frm_Especies_Load(object sender, EventArgs e)
        {
            ParaConectar.Conectar();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            spc_Menu.Panel2.Controls.Clear();
            spc_Menu.Panel2.Controls.Add(new Modificar1 ());
        }
    }
}
