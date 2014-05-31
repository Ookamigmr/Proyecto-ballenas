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


namespace AgregarUsuarios
{
    
    public partial class DatosInvestigación : UserControl,Interfacecita 
    {
        public DatosInvestigación()
        {
            InitializeComponent();
        }

        private void DatosInvestigación_Load(object sender, EventArgs e)
        {
            DataTable Lugares;
            Acciones a = new Acciones();

            Lugares = ParaConectar.ConsultarTodo("TRB_REGION");

            a.AgregarCombobox(Lugares, cmb_Lugares, "UBICACION");


            Lugares = ParaConectar.ConsultarTodo("TRB_ESPECIE");

            a.AgregarCombobox(Lugares, cmb_Ballenas, "NCIENT");
            

            


        }

        
        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ConfirmaciónContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_Ballenas.Text != null && cmb_Lugares.Text != null)
            {
                Contenedor.usuario.Especie = getId("TRB_ESPECIE", cmb_Ballenas.Text, "[NCIENT]");//int.Parse(ParaConectar.Consultar("TRB_ESPECIE", cmb_Ballenas.Text, "[NCIENT]").Rows.ToString());//cmb_Ballenas.SelectedIndex+1 ;
                Contenedor.usuario.Lugar = getId("[TRB_REGION]", cmb_Lugares.Text, "[UBICACION]");//int.Parse(ParaConectar.Consultar("[TRB_REGION]",  cmb_Lugares.Text,"[UBICACION]").Rows.ToString());//cmb_Lugares.SelectedIndex+1;
                if (Contenedor.usuario.Agregar())
                {
                    MessageBox.Show("Usuario Agregado");
                    Delegados.cerrar();
                }
                else
                    MessageBox.Show("Deberías revisar otra vez");

            }
        }

    
        private int getId(string t,string p,string q)
        {
            int id=0;
            DataTable dt = ParaConectar.Consultar(t, p, q);

            foreach (DataRow r in dt.Rows)
            {
                id = int.Parse(r["ID"].ToString());
            }

            return id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_Lugares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
