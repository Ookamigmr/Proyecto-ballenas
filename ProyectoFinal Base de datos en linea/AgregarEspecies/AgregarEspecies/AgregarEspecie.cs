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
    public partial class AgregarEspecie : UserControl
    {
        public AgregarEspecie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                string nombreComun, nombreCientifco, color, descripción, alimentación;
                double talla, gestación, peso, vida;


                nombreCientifco = txt_nombreCientifico.Text;
                nombreComun = txt_nombreComun.Text;
                color = txt_Color.Text;
                descripción = txt_Descripción.Text;
                alimentación = txt_Alimentacion.Text;


                try
                {
                    
                    talla = double.Parse(txt_Talla.Text);
                    gestación  = double.Parse(txt_Gestación. Text);
                    vida = double.Parse(txt_Vida. Text);
                    peso = double.Parse(txt_Peso. Text);
                    if (talla<=0 || peso <=0 || vida <=0|| gestación<=0)
                        throw new Exception("Los valores deben ser mayores a 0");




                    Especie especie;
                    
                    especie = (new Especie(nombreComun ,nombreCientifco , color,descripción , alimentación ,talla ,peso ,vida ,gestación) );
                    especie.Guardad();
                    foreach (Control o in this.Controls)
                    {
                        if (o is TextBox)
                        {
                            o.Text = "";
                        }
                    }

                }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
 
            }

                
           
        }

        private void AgregarEspecie_Load(object sender, EventArgs e)
        {

        }
    }
}
