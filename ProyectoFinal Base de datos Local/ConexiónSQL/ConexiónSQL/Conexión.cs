using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ConexiónSQL
{
    public  static  class ParaConectar
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader leer;
        static SqlDataAdapter adaptador;
        public static void Conectar()
        {
            conexion = new SqlConnection();
            //string datos = @"Data Source= workstation id=RBALLENASDB.mssql.somee.com;packet size=4096;user id=Ookami_SQLLogin_1;pwd=eni365y9vu;data source=RBALLENASDB.mssql.somee.com;persist security info=False;initial catalog=RBALLENASDB";
            string datos = @"Data Source= localhost;Initial Catalog=RBALLENASBD;Integrated Security=True";
            try
            {
                conexion.ConnectionString = datos;
                conexion.Open();
            }
            catch 
            {
               
            }
        }
        public static void Conectar(string baseDeDatos)
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source = localhost;Initial Catalog="+ baseDeDatos +";Integrated Security=True";
            conexion.Open();
        }
        public static SqlDataReader Buscar(string Tabla, string Regstro, string campo)
        {  
            string cadenaSQL;
           
                cadenaSQL = "Select * from " + Tabla + " where " + campo + " = '" + Regstro + "'";
          
            comando = new SqlCommand(cadenaSQL, conexion);
            try
            {
                conexion.Open();
            }
            catch
            {
            }
            leer = comando.ExecuteReader();
            conexion.Close();
            return leer;
        }
        public static bool Insertar(List<string> valor)
        {
            try
            {
                string cadenaSQL = Delegados.insertar();
                string valores = "(";
                for (int j = 0; j < valor.Count; j++)
                {
                    valores = valores + valor[j] ;
                }
                //char[] c;
                //c = valores.ToCharArray();
                //valores = "";
                //for (int j = 0; j < c.Length - 3; j++)
                //{ valores = valores + c[j]; }

                valores = valores + ")";


                cadenaSQL = cadenaSQL + valores;
                try
                {
                    conexion.Open();
                }
                catch
                {
                }
                comando = new SqlCommand(cadenaSQL, conexion);
                int i = comando.ExecuteNonQuery();
                conexion.Close();
                if (i <= 0)
                    throw new Exception();

                return true;
            }

            catch (Exception e)
            {
                Exception a=e;
                return false;
            }

            
        }
        public static bool Eliminar(string Tabla, string Registro, string campo)
        {
            try {

                try
                {
                    conexion.Open();
                }
                catch { }

                string cadenaSQL = "delete from " + Tabla + " where " + campo + "='" + Registro + "' ";
                comando = new SqlCommand(cadenaSQL, conexion);
                int i = comando.ExecuteNonQuery();
                conexion.Close();
                if (i <= 0)
                    throw new Exception();


                return true;
            }

            catch {
                return false;
            }
        
        }
        public static bool Cambiar(string Tabla, string Registro, string campo)
        {
            try
            {

                try
                {
                    conexion.Open();
                }
                catch
                {

                }

                string cadenaSQL = "update " + Tabla + " set " + campo + " where ID= '" + Registro + "' ";
                comando = new SqlCommand(cadenaSQL, conexion);
                int i = comando.ExecuteNonQuery();
                conexion.Close();
                if (i <= 0)
                    throw new Exception();


                return true;
            }

            catch
            {
                return false;
            }

        }
        public static DataTable ConsultarTodo(string Tabla)
        {
            string cadenaSQL = "select * from " + Tabla ;
            adaptador = new SqlDataAdapter(cadenaSQL,conexion );
            DataSet ds = new DataSet();
            adaptador.Fill(ds, Tabla);
            DataTable dt = ds.Tables[Tabla];
            return dt;
 
        }
        public static DataTable  Consultar(string Tabla, string Regstro, string campo)
        {
            string cadenaSQL = "Select * from " + Tabla + " where " + campo + " = '" + Regstro + "'"; ;
            adaptador = new SqlDataAdapter(cadenaSQL, conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, Tabla);
            DataTable dt = ds.Tables[Tabla];
            return dt;
        }
        public static DataTable Consultar(string Tabla, List<string> Regstro, List<string> campo)
        {
            string cadenaSQL = "Select * from " + Tabla + " where ";
            string Condicion="";
            int k=0;
            for ( k = 0; k < Regstro.Count - 1; k++)
            {
                Condicion = Condicion + campo[k] + "= '" + Regstro[k] + "', ";
            }
            Condicion = Condicion + campo[k] + "= '" + Regstro[k] + "'";

            cadenaSQL = cadenaSQL + Condicion;



            adaptador = new SqlDataAdapter(cadenaSQL, conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, Tabla);
            DataTable dt = ds.Tables[Tabla];
            return dt;
        }
        public static int ObtenerValorParaClave(string Tabla)
        {
            DataTable dt = ConsultarTodo(Tabla);

            int i = dt.Rows.Count;
            return i;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tabla"></param>
        /// <param name="Clave">Donde se cambaran</param>
        /// <param name="campo">Valores que se cambiarn</param>
        /// <returns></returns>
        internal static bool CambiarConClave(string Tabla, string Clave, string campo)
        {
            {
                try
                {

                    try
                    {
                        conexion.Open();
                    }
                    catch
                    {

                    }

                    string cadenaSQL = "update " + Tabla + " set " + campo + " where CLAVE= '" + Clave + "' ";
                    comando = new SqlCommand(cadenaSQL, conexion);
                    int i = comando.ExecuteNonQuery();
                    conexion.Close();
                    if (i <= 0)
                        throw new Exception();


                    return true;
                }

                catch
                {
                    return false;
                }

            }
        }
/// <summary>
/// 
/// </summary>
/// <param name="valor"></param>
/// <returns></returns>
       /* public static bool ActualizarTodos(List<string> valor)
        {
            try
            {
                string cadenaSQL = Delegados.Actualizar();
                string valores = "('";
                for (int j = 0; j < valor.Count; j++)
                {
                    valores = valores + valor[j] + "', '";
                }
                char[] c;
                c = valores.ToCharArray();
                valores = "";
                for (int j = 0; j < c.Length - 3; j++)
                { valores = valores + c[j]; }

                valores = valores + ")";


                cadenaSQL = cadenaSQL + valores;
                try
                {
                    conexion.Open();
                }
                catch
                {
                }
                comando = new SqlCommand(cadenaSQL, conexion);
                int i = comando.ExecuteNonQuery();
                conexion.Close();
                if (i <= 0)
                    throw new Exception();

                return true;
            }

            catch (Exception e)
            {
                Exception a = e;
                return false;
            }


        }
        */

        public static int ObtenerID(string tabla, string clave)
        {
            string cadenaSQL = " SELECT ID FROM "+tabla + " WHERE CLAVE = '"+clave+"'";
            try
            {
                conexion.Open();
            }
            catch
            {

            }
            comando= new SqlCommand (cadenaSQL,conexion);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            return id;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="valorLlave">Qué se tomará por clave</param>
        /// <param name="clave">Valor de clave</param>
        /// <returns></returns>
        public static int ObtenerID_SinClave(string tabla, string valorLlave, string clave)
        {
            string cadenaSQL = " SELECT ID FROM " + tabla + " WHERE "+valorLlave +" = '" + clave + "'";
            try
            {
                conexion.Open();
            }
            catch
            {

            }
            comando = new SqlCommand(cadenaSQL, conexion);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            return id;
        }
    }
}
