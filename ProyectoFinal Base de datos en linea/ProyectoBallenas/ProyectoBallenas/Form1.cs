using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AgregarUsuarios;
using System.Windows.Forms;
using ConexiónSQL;
using Grupos;

namespace ProyectoBallenas
{
    public partial class PantallaInicio : Form
    {
        DataTable dt;
        public PantallaInicio()
        {
            InitializeComponent();

         


        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Form forma = new AgregarUsuarios.Form1();
            forma.Show ();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form forma = new Grupos.frm_Investigación();
           forma.Show();
           // Grupos.Delegados.UsuarioEnCuestión= 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ParaConectar.Conectar();
            AgregarUsuarios.Acciones a = new AgregarUsuarios.Acciones();
            try
            {
                dt = ParaConectar.ConsultarTodo("TRB_USR");
                a.AgregarCombobox(dt, cmx_Usuario, "USR");
                if (cmx_Usuario.Items.Count < 1)
                    throw new Exception();
            }
            catch
            {
                Form carga = new Carga();
                carga.ShowDialog();
            }

        }

        private void cmx_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = cmx_Usuario.Text;
                dt = ParaConectar.Consultar("TRB_USR", usuario, "USR");
                DataRow usr = dt.Rows[0];
                if (usr["PWD"].ToString() == txt_contraseña.Text)
                {
                    btn_Ingresar.Enabled = true;
                    Usuario u = new Usuario(usr["USR"].ToString(), usr["NOM"].ToString(), usr["APLL"].ToString(), (int)usr["ID_REGION"], (int)usr["ID_ESPECIE"]);

                    Grupos.Delegados.UsuarioEnCuestión = delegate { return u; };
                    if (usr["ID"].ToString() == "1")
                    {
                        btn_Usuarios.Enabled = true;
                        btn_Regiones.Enabled = true;
                        btn_Especies.Enabled = true;
                    }

                }
                else
                {
                    MessageBox.Show("Contraseña Erronea");
                }
            }
            catch
            {
                MessageBox.Show("Nombre de usuario nulo o inexistente");
            }
        }

        private void btn_Especies_Click(object sender, EventArgs e)
        {
            Form forma = new AgregarEspecies.frm_Especies();
            forma.Show();
        }

        private void btn_Regiones_Click(object sender, EventArgs e)
        {
            Form forma = new AgregarRegiones.Regiones();
            forma.Show();
        }
    }
}
