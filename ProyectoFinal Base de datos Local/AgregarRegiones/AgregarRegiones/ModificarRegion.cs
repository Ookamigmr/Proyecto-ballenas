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
    public partial class ModificarRegion : UserControl
    {
        public ModificarRegion()
        {
            InitializeComponent();
        }
        ConexiónSQL.Region region;
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string ubicacion, clave, descripción, alimentación;
            double clima, tempAgua, profMax, area;


            clave = txt_Clave.Text;
            ubicacion = txt_nombreComun.Text;

            descripción = txt_Descripción.Text;
            alimentación = txt_Alimentacion.Text;

            try
            {

                clima = double.Parse(txt_Talla.Text);
                
                profMax = double.Parse(txt_Vida.Text);
                tempAgua = double.Parse(txt_Peso.Text);
                if (clima <= 0 || profMax <= 0)
                    throw new Exception("Los valores deben ser mayores a 0");




               

                region = (new ConexiónSQL.Region(clave, ubicacion, descripción, alimentación, tempAgua, profMax, 0, (int)clima));
                region.ActualizarTodo();
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

 

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Clave.Text))
            {
                DataTable resultado;
                
                    int id = ParaConectar.ObtenerID("TRB_REGION", txt_Clave.Text);
                    resultado = ParaConectar.Consultar("TRB_REGION", id.ToString(), "ID");




                   

               
                try
                {

                    DataRow DatosEspecie = resultado.Rows[0];
                    region = new ConexiónSQL.Region(txt_Clave.Text, DatosEspecie["UBICACION"].ToString(), DatosEspecie["DESCR"].ToString(), DatosEspecie["T_ALIMENTACION"].ToString(), double.Parse(DatosEspecie["TEMP_AGUA"].ToString()), double.Parse(DatosEspecie["PROFUNDIDAD"].ToString()),0, int.Parse((DatosEspecie["CLIMA"]).ToString()));


                    

                    txt_nombreComun.Text = DatosEspecie["UBICACION"].ToString();
                    txt_Descripción.Text = DatosEspecie["DESCR"].ToString();

                    txt_Talla.Text = DatosEspecie["CLIMA"].ToString();
                    txt_Peso.Text = (DatosEspecie["TEMP_AGUA"]).ToString();

                    txt_Alimentacion.Text = DatosEspecie["T_ALIMENTACION"].ToString();
                    txt_Vida.Text = DatosEspecie["PROFUNDIDAD"].ToString();
                    


                }
                catch
                {
                    txt_Clave.Focus();
                    MessageBox.Show("No se encontró el número de control. Si usted desconoce este valor, busque mediante coincidencias");
                }
            }

        }
    }
}
