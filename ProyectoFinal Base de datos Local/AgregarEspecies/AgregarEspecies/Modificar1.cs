using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexiónSQL;

namespace AgregarEspecies
{
    public partial class Modificar1 : UserControl
    {
        public Modificar1()
        {
            InitializeComponent();
        }


        Especie especie;

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable resultado;
            if (rbt_Clave.Checked)
            {
                int id = ParaConectar.ObtenerID("TRB_ESPECIE", txt_Clave.Text);
                resultado = ParaConectar.Consultar("TRB_ESPECIE", id.ToString(), "ID");
                


            }
            else
            {
                int id = ParaConectar.ObtenerID_SinClave("TRB_ESPECIE", "NCIENT", txt_nombreCientifico.Text);
                resultado = ParaConectar.Consultar("TRB_ESPECIE", id.ToString(), "ID");
                
            }
            try
            {
                
                DataRow DatosEspecie = resultado.Rows[0];
                especie = new Especie(DatosEspecie["NCOMUN"].ToString(), DatosEspecie["NCIENT"].ToString(), DatosEspecie["COLOR"].ToString(), DatosEspecie["T_ALIMENTACION"].ToString(), DatosEspecie["CMORFOLOGIA"].ToString(), double.Parse(DatosEspecie["TALLA"].ToString()), double.Parse((DatosEspecie["PESO"]).ToString()), double.Parse((DatosEspecie["PESO"]).ToString()), double.Parse(DatosEspecie["TIEMPO_GEST"].ToString()));
                

                txt_Alimentacion.Text = DatosEspecie["T_ALIMENTACION"].ToString();
                txt_Vida.Text = DatosEspecie["VIDA_PROM"].ToString();
                txt_Gestación.Text = DatosEspecie["TIEMPO_GEST"].ToString();
                txt_nombreCientifico.Text = DatosEspecie["NCIENT"].ToString();
                txt_nombreComun.Text = DatosEspecie["NCOMUN"].ToString();
                txt_Descripción.Text = DatosEspecie["CMORFOLOGIA"].ToString();
                txt_Color.Text = DatosEspecie["COLOR"].ToString();
                txt_Talla.Text = DatosEspecie["TALLA"].ToString();
                txt_Peso.Text = (DatosEspecie["PESO"]).ToString();

                txt_Alimentacion.Text = DatosEspecie["T_ALIMENTACION"].ToString();
                txt_Vida.Text = DatosEspecie["VIDA_PROM"].ToString();
                txt_Gestación.Text = DatosEspecie["TIEMPO_GEST"].ToString();
                


            }
            catch
            {
                txt_Clave.Focus();
                MessageBox.Show("No se encontró el número de control. Si usted desconoce este valor, busque mediante coincidencias");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                especie.IngresarDatos(txt_nombreComun.Text, txt_Color.Text, txt_Descripción.Text, txt_Alimentacion.Text, double.Parse(txt_Talla.Text), double.Parse(txt_Peso.Text), double.Parse(txt_Vida.Text), double.Parse(txt_Gestación . Text));
                especie.ActualizarTodo();

               foreach (Control   o in this.Controls)
                {
                    if ( o is TextBox)
                    {
                        o.Text= "";
                    }
                }

            }
            catch
            {
                MessageBox.Show("Posible error en el formato de los valores");
            }

        }
    }
}
