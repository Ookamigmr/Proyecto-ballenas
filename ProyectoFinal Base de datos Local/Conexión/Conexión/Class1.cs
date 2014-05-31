using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Conexión
{
    public class Coneccion
    {

        
        void ConeccionSql()
        {
            SqlConnection cs = new SqlConnection("Data Source=localhost; Initial Catalog=RBALLENAS; Integrated Security=SSPI; Persist Security Info=false; Trusted_Connection=Yes");
            cs.Open();
            
            cs.Close();
        }

    }
}
