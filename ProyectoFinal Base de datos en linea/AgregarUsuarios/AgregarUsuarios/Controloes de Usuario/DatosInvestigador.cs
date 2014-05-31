using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgregarUsuarios
{
    public partial class DatosInvestigador : UserControl, Interfacecita
    {
        bool Listo = false;
        public DatosInvestigador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*NuevoUsuario  U = new NuevoUsuario() ;
            SplitContainer  sC = ((SplitContainer )U.Controls[0] );
            Delegados.SeñalUsuarios= delegate {return new DatosInvestigación ();};
            
            CheckBox C =(CheckBox) sC.Panel1.Controls["chb_DatosCuenta"];
                C.Checked = true;
              this.Controls. Add(new DatosInvestigación());
             */
            
            this.Dispose();
            Delegados.SeñalUsuarios = delegate { return new DatosInvestigación(); };
            Delegados.evento();
            
        }

        private void txt_NombreUsuario_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_NombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txt_NombreUsuario.Text != "" && txt_NombreUsuario.Text.Length > 3)
                {
                    txt_Contraseña.Enabled = true;
                    txt_Contraseña.Focus();
                }
                else
                    txt_NombreUsuario.SelectAll();

            }
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txt_Contraseña.Text != "" && txt_Contraseña.Text.Length > 4)
                {
                    txt_ConfirmaciónContraseña.Enabled = true;
                    txt_ConfirmaciónContraseña.Focus();
                }
                else
                    txt_Contraseña.SelectAll();
                



            }
        }

        private void txt_ConfirmaciónContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txt_Contraseña.Text == txt_ConfirmaciónContraseña.Text )
                {
                    cmb_titulo.Enabled = true;
                    txt_NombreInvestigador.Enabled = true;

                    txt_NombreInvestigador.Focus();
                }
                else
                    txt_ConfirmaciónContraseña.SelectAll();




            }
        }

 

        private void txt_NombreInvestigador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txt_NombreInvestigador.Text != "" && txt_NombreInvestigador.Text.Length > 3)
                {
                    txt_Apellidos.Enabled = true;
                    txt_Apellidos.Focus();
                }
                else
                    txt_NombreInvestigador.SelectAll();




            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txt_Apellidos.Text != "" && txt_Apellidos.Text.Length > 3)
                {
                    btn_Continuar . Enabled = true;
                    btn_Continuar.Focus();
                }
                else
                    txt_Apellidos.SelectAll();




            }
        }



        private void btn_Continuar_Click(object sender, EventArgs e)
        {

            IrCreandoUsuario();

            this.Dispose();
            Delegados.SeñalUsuarios = delegate { return new DatosInvestigación(); };
            Delegados.evento();
            Delegados.evento = delegate { };
            Delegados.SeñalUsuarios = null;

            
        }

        private void IrCreandoUsuario()
        {
            if (cmb_titulo.SelectedIndex > 1)
            {
                Contenedor.usuario = new ConexiónSQL.Usuario(txt_NombreUsuario.Text, txt_Contraseña.Text, txt_NombreInvestigador.Text, txt_Apellidos.Text);
            }
            else
            {
                Contenedor.usuario = new ConexiónSQL.Usuario(txt_NombreUsuario.Text, txt_Contraseña.Text, txt_NombreInvestigador.Text, txt_Apellidos.Text, cmb_titulo.Text);
            }
        }



       
    }
}
