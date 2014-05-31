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
    public partial class AgregarPoblaciones : UserControl, Interfacecita 
    {
        Usuario investigador;
        public AgregarPoblaciones()
        {
            InitializeComponent();
            investigador = Delegados.UsuarioEnCuestión();
        }

        private void AgregarPoblaciones_Load(object sender, EventArgs e)
        {
            DataTable Lugares;
            Acciones a = new Acciones();

            Lugares = ParaConectar.ConsultarTodo("TRB_REGION");

            a.AgregarCombobox(Lugares, cmb_Lugares, "UBICACION");


            Lugares = ParaConectar.ConsultarTodo("TRB_ESPECIE");

            a.AgregarCombobox(Lugares, cmb_Ballenas, "NCIENT");
            cmb_Ballenas.SelectedIndex = investigador.Especie - 1;
            cmb_Lugares.SelectedIndex = investigador.Lugar - 1;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int especie, zona, numero;
            DateTime fecha;
            especie = cmb_Ballenas.SelectedIndex + 1;
            zona = cmb_Lugares.SelectedIndex + 1;
            fecha = dtp_Llegada.Value;
            try
            {

                Poblacion grupo = new Poblacion(fecha, zona, especie);



   
                if (grupo.Guardad())
                {
                    MessageBox.Show("Agregado con éxito");
                }
                else
                    throw new Exception("Fallo en guardar registro");
                if (nup_Miembros.Value > 0)
                {
                    numero = (int)nup_Miembros.Value;
                    grupo.AgregarNumero(numero);

                }
                
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message );
 
            }
        }
    }
}
