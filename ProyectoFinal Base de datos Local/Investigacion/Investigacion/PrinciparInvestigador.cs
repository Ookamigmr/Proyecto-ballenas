using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexiónSQL;

namespace Grupos
{
    public partial class frm_Investigación : Form
    {
        Usuario Invesrigador;

        public frm_Investigación()
        {
            InitializeComponent();
            ParaConectar.Conectar();
            if (Delegados.UsuarioEnCuestión != null)

                Invesrigador = Delegados.UsuarioEnCuestión();
            else
            {
                DataTable dt=ParaConectar.Consultar("TRB_USR", "1", "ID");
                Invesrigador = new Usuario(dt.Rows[0]["USR"].ToString(), dt.Rows[0]["NOM"].ToString(), dt.Rows[0]["APLL"].ToString(), Convert.ToInt16(dt.Rows[0]["ID_REGION"]), Convert.ToInt16(dt.Rows[0]["ID_ESPECIE"]));

            }
            Delegados.UsuarioEnCuestión = delegate { return Invesrigador; };
            Delegados.Accion = delegate { pnl_Visualizar.Controls.Clear(); pnl_Visualizar.Controls.Add(Delegados.UserControlSiguiente()); };
        }

        private void frm_Investigación_Load(object sender, EventArgs e)
        {

            this.Text = Invesrigador.usuario;
            DataTable dt = ParaConectar.Consultar("TRB_ESPECIE", Invesrigador.Especie.ToString(), "ID");
            lbl_Especie.Text = dt.Rows[0]["NCIENT"].ToString();
            dt = ParaConectar.Consultar("TRB_REGION", Invesrigador.Especie.ToString(), "ID");
            lbl_Region.Text = dt.Rows[0]["UBICACION"].ToString();

            //Delegados.UserControlSiguiente = delegate {return  };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_Visualizar.Controls.Clear();
            pnl_Visualizar.Controls.Add(new Poblaciones());
        }
    }
}
