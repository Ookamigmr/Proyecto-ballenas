using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexiónSQL;

namespace AgregarUsuarios
{
    public partial class Buscar_usuario : UserControl, Interfacecita 
    {
        public Buscar_usuario()
        {
            InitializeComponent();
        }


        private void btb_Buscar_Click(object sender, EventArgs e)
        {
            BuscarSinID();
        }

        private void BuscarSinID()
        {
           
           List<string> registros, campos;
           registros = new List<string>();
           campos = new List<string>();
           Delegados.SeñalUsuarios = delegate { return new Usuarios_Encontrados (); };

            foreach (Control o in this.Controls )
            {
                string Nombre=o.Name;
                if (o is ComboBox || o is TextBox)
                if (!String.IsNullOrEmpty(o.Text ))
                {
                    campos.Add(Nombre);
                    if ((o is TextBox )|| Nombre=="TIT") 
                    {
                        registros.Add(o.Text);
                        
                    }
                    else 
                    {
                        registros.Add((((ComboBox)o).SelectedIndex+1).ToString());

                    }

                }
                
 
            }
            Contenedor.tablaDatos = ConexiónSQL.ParaConectar.Consultar("TRB_USR", registros, campos);
            this.Dispose();
            Delegados.cerrar();
            Delegados.evento = null;
        }
        /*
        void BuscarConID()
        {
            this.Dispose();
            Modificar_Usuario MD = new Modificar_Usuario();
            Delegados.SeñalUsuarios = delegate { return MD; };

            Contenedor.algunValor = txt_Id.Text;
            Delegados.cerrar();
            Delegados.evento = null;
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            BuscarConID();
        }
         */

        private void Buscar_usuario_Load(object sender, EventArgs e)
        {
            DataTable Lugares;
            Acciones a = new Acciones();

            Lugares = ParaConectar.ConsultarTodo("TRB_REGION");

            a.AgregarCombobox(Lugares, ID_REGION , "UBICACION");


            Lugares = ParaConectar.ConsultarTodo("TRB_ESPECIE");

            a.AgregarCombobox(Lugares, ID_ESPECIE, "NCIENT");
            
        }


        private void rbt_ID_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
