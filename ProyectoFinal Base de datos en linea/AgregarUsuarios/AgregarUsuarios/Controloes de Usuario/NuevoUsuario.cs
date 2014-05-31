using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgregarUsuarios
{
    public partial class NuevoUsuario : UserControl, Interfacecita 
    {
        Interfacecita I;
        public NuevoUsuario()
        {
            Delegados.SeñalUsuarios = Inicio;
            InitializeComponent();
            sc_NuevoUsuario.Panel2.Controls.Add(Delegados.SeñalUsuarios());
            Delegados.evento = delegate { chb_DatosInvestigación . Checked = true; };
           
        }
        UserControl Inicio()
        {
            return new DatosInvestigador();
        }
        private void chb_DatosCuenta_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void chb_DatosInvestigación_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_DatosCuenta.Checked)
            {
                chb_DatosCuenta.Checked = true;
                sc_NuevoUsuario.Panel2.Controls.Add(Delegados.SeñalUsuarios());
            }
        }


    }
}
