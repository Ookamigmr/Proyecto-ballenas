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
namespace AgregarUsuarios
{
   public  class Acciones
    {
        public  void AgregarCombobox(DataTable dt, ComboBox cb, string Columna)
        {
            foreach (DataRow r in dt.Rows)
            {
                cb.Items.Add(r[Columna].ToString());
                //cb.SelectedIndex. = int.Parse(r["ID"].ToString());
                //cb.Items.IndexOf(r["ID"]);
                
            }
        }
        public void AgregarValor(string valor,TextBox txt)
        {
            txt.Text = valor;
        }
       public void LlenarCon(DataTable dt,ref Dictionary<int,string>dic, string campo)
       {
           foreach (DataRow r in dt.Rows)
           {
               dic.Add(Convert.ToInt16(r["ID"]), campo);

           }
       }
    }
}
