using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexiónSQL;
using System.Data.SqlClient;


namespace Grupos
{

    public partial class BallenasDePoblacione : UserControl, Interfacecita 
    {
        public BallenasDePoblacione()
        {

            InitializeComponent();

        }


        private void BallenasDePoblacione_Load(object sender, EventArgs e)
        {
            Poblacion poblacion=Delegados.ePoblacion();
            DataTable dt = ParaConectar.Consultar("TRB_MUESTRAS", poblacion.id.ToString(), "ID_POBLACION");

            dgv_Ballenas.DataSource = dt;
            dgv_Ballenas.Columns["ID_ESPECIE"].Visible = false;
            dgv_Ballenas.Columns["ID_POBLACION"].Visible = false;
            dgv_Ballenas.Columns["ID_EVIDA"].Visible = false;
            dgv_Ballenas.Columns["ULT_ACT"].Visible = false;
            dgv_Ballenas.Columns["ID"].Visible = false;
            dgv_Ballenas.Columns["SEXO"].Visible = false;
            dgv_Ballenas.Columns.Add("sexoE", "GENERO");
            dgv_Ballenas.Columns.Add("etapa", "ETAPA");

            Delegados.llenarConEntero(dgv_Ballenas.RowCount - 1);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Delegados.UserControlSiguiente = delegate {return  new Agregar_Ballena(); };
            Delegados.pequeñaAccion();

        }

        private void BallenasDePoblacione_Enter(object sender, EventArgs e)
        {
            int registros = dgv_Ballenas.RowCount - 1;
            for (int i = 0; i < registros; i++)
            {
                int etapa = (int)dgv_Ballenas["ID_EVIDA", i].Value;
                switch (etapa)
                {
                    case 1:
                        dgv_Ballenas["etapa", i].Value = "Cria";
                        break;


                    case 4:
                        dgv_Ballenas["etapa", i].Value = "Juvenil";
                        break;


                    case 5:
                        dgv_Ballenas["etapa", i].Value = "Reproductor";
                        break;
                }
                bool s = (bool)dgv_Ballenas["SEXO", i].Value;
                if (s)
                    dgv_Ballenas["sexoE", i].Value = "Hembra";
                else
                    dgv_Ballenas["sexoE", i].Value = "Macho";
            }
        }
    }
}
