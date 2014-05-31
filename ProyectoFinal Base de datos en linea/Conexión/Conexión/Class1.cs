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

        SqlConnection conexion;

        void ConeccionSql()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString =
"Data Source=alma-PC;" +
"Initial Catalog=CREACION DE TABLAS TRB;" +
"User id=alma;" +
"Password=Secret;";
            conexion.Open();
        }

    }
}
