using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexiónSQL;

namespace AgregarRegiones
{
    public partial class AgregarRegion : UserControl
    {
        public AgregarRegion()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string ubicacion, clave, descripción, alimentación;
            double clima, tempAgua, profMax, area;


            clave = txt_nombreCientifico.Text;
            ubicacion = txt_nombreComun.Text;
           
            descripción = txt_Descripción.Text;
            alimentación = txt_Alimentacion.Text;

            try
            {

                clima = double.Parse(txt_Talla.Text);
                 area=double.Parse(txt_Area.Text );
                profMax = double.Parse(txt_Vida.Text);
                tempAgua = double.Parse(txt_Peso.Text);
                if (clima <= 0 ||  profMax <= 0 )
                    throw new Exception("Los valores deben ser mayores a 0");




                ConexiónSQL.Region   region;

                region = (new ConexiónSQL.Region(clave, ubicacion, descripción, alimentación, tempAgua, profMax,area, (int)clima));
                region.Guardad();
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
    }
}
