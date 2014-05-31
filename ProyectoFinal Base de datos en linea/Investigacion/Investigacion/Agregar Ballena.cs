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
    public partial class Agregar_Ballena : UserControl, Interfacecita 
    {
        bool Pase = true;
        int año;
        string alias,s;
        bool sexo;
        float  longitud;
        Poblacion poblacion;
        int especie, region;
        int esteAño;
        public Agregar_Ballena()
        {
            InitializeComponent();
            poblacion = Delegados.ePoblacion();
            especie = poblacion.id_especie;
            region = poblacion.id_región;

        }


        private void txt_Año_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar==13) 
            {
                ExaminarAño();

            }
        
        }

        private void ExaminarAño()
        {
            int año;
            try
            {
                año = int.Parse(txt_Año.Text);
                if (año > DateTime.Today.Year || año < DateTime.Today.Year - 200)
                    throw new Exception("La fecha de nacimiento es incongruente. Si efectivamente la edad caclulada supera los 200 años de edad, consulte a su administrador.");
                Pase = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Pase = false;
            }
            catch
            {
                MessageBox.Show("El año debe ser escrito con número y entero");
                Pase = false;
            }
        }

        private void Agregar_Ballena_Load(object sender, EventArgs e)
        {
            DataTable dt =ParaConectar.ConsultarTodo("TRB_EVIDA");
            Acciones a = new Acciones();
            a.AgregarCombobox(dt, cbx_EtapaVida, "CLAVE");

            esteAño=DateTime.Today.Year;
                
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Pase = true;
                alias = txt_Alias.Text;
                


                //sexo
                sexo = !rbt_Sexo.Checked;

                if (sexo)
                    s = "H";
                else
                    s = "M";


                //longitud
                examinarLongitud();
                if (!Pase)
                    throw new Exception("Error en la longitud");



                //etapa de vida
                string etapa = cbx_EtapaVida.Text;
                int etap = ParaConectar.ObtenerID("TRB_EVIDA", etapa);
                Ballena B;
                if (rbt_ConEtapa.Checked)
                    B = new Ballena(sexo, longitud,etap, especie, poblacion.id);
                else
                {
                    if (rbt_Bebe.Checked)
                    {
                        año = esteAño;
                        etap=1;
                    }
                    else
                    {
                        ExaminarAño();
                        if (Pase)
                        {año = int.Parse(txt_Año.Text);
                            if (esteAño-año <2)
                                etap=1;
                            else if (esteAño < 10)
                                etap=4;
                            else
                                etap=5;
                        }
                        else
                            throw new Exception("Error en el año");
                    }



                    ///CREANDO
                    B = new Ballena(sexo,longitud, etap,especie,poblacion.id,año);

                    //ALIAS
                    
                   
                }
               // if (poblacion.n_población<
                B.alias = alias;
                if (B.Guardad())
                {
                    MessageBox.Show("Miembro agregado");

                }
                else
                    throw new Exception("Error en la actualizacion de datos");

                txt_Alias.Clear();
                txt_Longitud.Clear();
                txt_Año.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
            
            finally
            {
                Fin();
            }
        }

        private void    examinarLongitud( )
        {
            float  d;
            try
            {
                d = float.Parse(txt_Longitud.Text);
                longitud = d;
 
            }
            catch {
                MessageBox.Show("La longuitud debe ser escrita con número");
                Pase = false;

            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Fin();
        }

        private void Fin()
        {
            Delegados.UserControlSiguiente = delegate { return new BallenasDePoblacione (); };
            Delegados.pequeñaAccion();
        }

        private void txt_Alias_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Longitud_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
