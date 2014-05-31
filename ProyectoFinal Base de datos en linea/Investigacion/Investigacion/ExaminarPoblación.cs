using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexiónSQL;


namespace Grupos
{
    public partial class ExaminarPoblación : UserControl, Interfacecita 
    {
        Poblacion población;
        public ExaminarPoblación()
        {
            InitializeComponent();
            
            población = Delegados.ePoblacion();

        }

        private void ExaminarPoblación_Load(object sender, EventArgs e)
        {

            Delegados.pequeñaAccion = delegate
            {
                pnl_Ballenas.Controls.Clear();

                pnl_Ballenas.Controls.Add(Delegados.UserControlSiguiente());

            };
            Delegados.llenarConEntero = delegate(int q) { txt_Registrados.Text = q.ToString();
            if (int.Parse(txt_individuos.Text) < q)
                txt_individuos.Text  = q.ToString();
            };

            lbl_Clave.Text = población.clave;

            txt_individuos.Text  = población.n_población.ToString();
            txt_Notas.Text  = población.notas;
            txt_FechaLlegada.Text = población.fechaLlegada.Date.ToString();
            try
            {
                txt_FechaSalida.Text = población.fechaSalida.Date.ToString();
                if (población.fechaSalida.Year < 2000)
                    throw new Exception();
            }
            catch
            {
                txt_FechaSalida.Text = "Presente";
            }
            pnl_Ballenas.Controls.Add(new BallenasDePoblacione());

        }
        int aou = 0;
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            txt_individuos.ReadOnly = false;
            txt_Notas.ReadOnly = false;
            btn_Guardar.Visible = true;
            aou = 1;
        }

        private void btn_Salida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese fecha de despacho");
            dtp_Salida.Visible = true;
            btn_Guardar.Visible = true;
            aou = 2;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (aou == 1)
            {
                población.AgregarNumero(int.Parse(txt_individuos.Text));

                población.AgregarNota(txt_Notas.Text);

            }
            else
            { 
                población.Despachar(dtp_Salida.Value);
                txt_FechaSalida.Text  = dtp_Salida.Value.ToShortDateString();

            }


            
            aou = 0;
            btn_Guardar.Visible = false;
            dtp_Salida.Visible = false;
            txt_Notas.ReadOnly = true;
            txt_individuos.ReadOnly = true;

        }

    }
}
