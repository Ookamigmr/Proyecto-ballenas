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
using System.Data;


namespace AgregarUsuarios
{
      
    public partial class Modificar_Usuario : UserControl
    {string contraseña;
        public Modificar_Usuario()
        {
                      InitializeComponent();
                      
                      DataTable Lugares;
                      Acciones a = new Acciones();

                      Lugares = ParaConectar.ConsultarTodo("TRB_REGION");

                      a.AgregarCombobox(Lugares, cmb_Lugares, "UBICACION");


                      Lugares = ParaConectar.ConsultarTodo("TRB_ESPECIE");

                      a.AgregarCombobox(Lugares, cmb_Ballenas, "NCIENT");
            
                      
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            Desplegar();
                
        }
        void Desplegar()
        {
            ParaConectar.Conectar();
            int iD = int.Parse(txt_Id.Text);
            DataTable resultado = ParaConectar.Consultar("TRB_USR", iD.ToString(), "ID");
            try
            {
                DataRow Usuario = resultado.Rows[0];
                txt_NombreCuenta.Text = Usuario["USR"].ToString();
                txt_RepetirConstraseña.Text = Usuario["PWD"].ToString();
                cmb_Titulo.Text = Usuario["TIT"].ToString();
                txt_Nombre.Text = Usuario["NOM"].ToString();
                txt_Apellidos.Text = Usuario["APLL"].ToString();
                cmb_Ballenas.SelectedIndex = Convert.ToInt16(Usuario["ID_ESPECIE"])-1;
                cmb_Lugares.SelectedIndex = Convert.ToInt16(Usuario["ID_REGION"])-1;
                contraseña = Usuario["PWD"].ToString();
                chb_Activo.Checked = Convert.ToBoolean(Usuario["ACTIVO"]);
                txt_Contraseña.Focus();
            }
            catch 
            {
                txt_Id.Focus();
                MessageBox.Show("No se encontró el número de control. Si usted desconoce este valor, busque mediante coincidencias");
            }
        }



        private void Modificar_Usuario_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Contenedor.algunValor))
            {
                txt_Id.Text = Contenedor.algunValor;
                Contenedor.algunValor = null;
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string campo= "USR= '"+txt_NombreCuenta.Text+"', PWD='"+txt_Contraseña.Text+"', TIT='"+cmb_Titulo.Text+"', NOM ='"+txt_Nombre.Text+"', APLL='"+txt_Apellidos.Text+"', ID_ESPECIE='"+(cmb_Ballenas.SelectedIndex+1).ToString()+"', ID_REGION='"+(cmb_Lugares.SelectedIndex+1).ToString()+ "', ACTIVO='"+chb_Activo.Checked.ToString()+"', ULT_ACT='"+DateTime.Today.ToString()+"'";
            if (txt_Contraseña.Text == contraseña)
            {

                if (ParaConectar.Cambiar("TRB_USR", txt_Id.Text, campo))
                {
                    MessageBox.Show("Cambios realizado con éxito");

                }
                else
                {
                    MessageBox.Show("Mmmmm");
 
                }
              
            }
            else
            {
                MessageBox.Show("Ingrese la contraseña del usuario para cambios");
            }
        }

        private void btn_CambiarContraseña_Click(object sender, EventArgs e)
        {
            if (txt_RepetirConstraseña.Text == txt_Contraseña.Text)
            {
                if (ParaConectar.Cambiar("TRB_USR", txt_Id.Text, "PWD='" + txt_Contraseña.Text+"'"))
                {
                    contraseña = txt_Contraseña.Text;
                    MessageBox.Show("Nueva contraseña");
                }
                else
                    MessageBox.Show("Mala Programacion, no contó con un detalle");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                txt_Contraseña.Focus();
            }
        }



        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Contraseña.Text == contraseña)
            {
                HabilitarTodo(this);
                txt_Id.Enabled = false;
               /* txt_Nombre.ReadOnly = false;
                txt_NombreCuenta.ReadOnly = false;
                txt_Apellidos.ReadOnly = false;*/
                txt_RepetirConstraseña.Visible = true;

            }


        }
        void HabilitarTodo(UserControl  f)
        {


            foreach (Control v in f.Controls )
            {
                v.Enabled = true;
                if (v is TextBox)
                {
                    ((TextBox)v).ReadOnly = false;
                }

            }

        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Desplegar();
        }
    }
}
