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
    public partial class Poblaciones : UserControl, Interfacecita 
    {
        Usuario Invesrigador;
        public Poblaciones()
        {
            InitializeComponent();
        }

        private void Poblaciones_Load(object sender, EventArgs e)
        {
            Invesrigador = Delegados.UsuarioEnCuestión();
            Acciones a = new Acciones();
            DataTable dt = ParaConectar.Consultar("TRB_REGISTRO", Invesrigador.Lugar.ToString(), "ID_REGION");
            
            List<string> Campos= new List<string>();
            Campos.Add("ID");Campos.Add("CLAVE");Campos.Add("N_POBLACION");
            ltb_Poblaciones.Items.Add("ID\tClave\t\tIndiviuos");
            a.AgregarListbox(dt, ltb_Poblaciones , Campos  );



            
        }

        private void btn_NuevaPoblación_Click(object sender, EventArgs e)
        {
            Delegados.UserControlSiguiente = delegate { return new AgregarPoblaciones(); };
            Delegados.Accion();
        }

        private void btn_Comparar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zona en construcción");
        }

        private void ltb_Poblaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltb_Poblaciones.SelectedIndex > 0)
            {
                btn_ExaminarPoblación.Enabled = true;
                ltb_Ballenas.Items.Clear();
                string Linea = ltb_Poblaciones.Items[ltb_Poblaciones.SelectedIndex].ToString(), clave;

                string[] a = Linea.Split('\t');

                clave = a[0];

                DataTable dt = ParaConectar.Consultar("TRB_MUESTRAS", clave, "ID_POBLACION");
                Acciones A = new Acciones();


                List<string> Campos = new List<string>();
                Campos.Add("CLAVE"); Campos.Add("ALIAS");
                // ltb_Poblaciones.Items.Add("Clav\tClave\t\tIndiviuos");


                A.AgregarListbox(dt, ltb_Ballenas, Campos);



            }
            else
            {
                btn_ExaminarPoblación.Enabled = false;
            }
        }

        private void btn_ExaminarPoblación_Click(object sender, EventArgs e)
        {
            if (ltb_Poblaciones.SelectedIndex > 0)
            {
                ltb_Ballenas.Items.Clear();
                string Linea = ltb_Poblaciones.Items[ltb_Poblaciones.SelectedIndex].ToString(), clave;

                string[] a = Linea.Split('\t');

                clave = a[0];

                DataTable dt = ParaConectar.Consultar("TRB_REGISTRO", clave, "ID");
                DataRow dr = dt.Rows[0];
                Poblacion poblacion;
                if (string.IsNullOrEmpty( dr["FEC_FIN"].ToString()))
                {
                    poblacion = new Poblacion((DateTime)dr["FEC_INI"], (int)(dr["ID_REGION"]), (int)dr["ID_ESPECIE"], dr["CLAVE"].ToString(), (int)dr["N_POBLACION"], dr["NOTAS"].ToString());

                }
                else
                {
                    poblacion = new Poblacion((DateTime)dr["FEC_INI"], (int)(dr["ID_REGION"]), (int)dr["ID_ESPECIE"], dr["CLAVE"].ToString(), (int)dr["N_POBLACION"],dr["NOTAS"].ToString(), (DateTime)dr["FEC_FIN"]);
                }
                poblacion.id = (int)(dr["ID"]);
                Delegados.ePoblacion = delegate { return poblacion; };
                Delegados.UserControlSiguiente = delegate { return new ExaminarPoblación(); };
                Delegados.Accion();


               


            



            }


        }
    }
}
