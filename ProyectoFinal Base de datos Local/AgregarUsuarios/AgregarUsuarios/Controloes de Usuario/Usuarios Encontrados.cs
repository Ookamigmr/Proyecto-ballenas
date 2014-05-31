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
    public partial class Usuarios_Encontrados : UserControl, Interfacecita
    {
        public Usuarios_Encontrados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Encontrados_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Contenedor.tablaDatos;
            dgv_usuarios.Columns ["PWD"].Visible = false;
            dgv_usuarios.Columns["ID"].Visible = false;
           
            /*Dictionary<int,string > lugares, especies;
            Acciones a = new Acciones();
            lugares = new Dictionary<int, string>();
            especies  = new Dictionary<int, string>();
            DataTable dt=ConexiónSQL.ParaConectar.ConsultarTodo("TRB_REGION");
            a.LlenarCon(dt, ref lugares, "TRB_REGION");
             dt = ConexiónSQL.ParaConectar.ConsultarTodo("TRB_ESPECIE");
            a.LlenarCon(dt, ref especies , "TRB_ESPECIE");

           dgv_usuarios.Columns ["ID_REGION"].GetType();
            for (int y = 0; y < dgv_usuarios.RowCount-1; y++)
            {
                int o = Convert.ToInt16(dgv_usuarios["ID_REGION", y].Value);
                dgv_usuarios["ID_REGION", y].Value = lugares[o];
                dgv_usuarios["ID_ESPECIE", y].Value = especies[Convert.ToInt16(dgv_usuarios["ID_ESPECIE", y].Value)];

            }*/
        }

        private void MostrarDUSR(object sender, EventArgs e)
        {
            //this.Dispose();
            Contenedor.algunValor = dgv_usuarios.CurrentRow.Cells[0].Value.ToString();
            Modificar_Usuario MD = new Modificar_Usuario();
            Delegados.SeñalUsuarios = delegate { return MD; };

             //dgv_usuarios[0, dgv_usuarios.CurrentRow.Index].ToString();
             
            Delegados.cerrar();
            Delegados.evento = null;
        }

        private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
