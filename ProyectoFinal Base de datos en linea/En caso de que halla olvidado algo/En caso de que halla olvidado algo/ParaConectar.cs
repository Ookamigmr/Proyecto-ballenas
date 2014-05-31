using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace asd
{
    public static class ParaConectar
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader leer;
        static SqlDataAdapter adaptador;
        public static void Conectar()
        {
            conexion = new SqlConnection();
            string datos=@"Data Source= ALMA-PC\SQLEXPRESS;Initial Catalog=ProyectoBallenas;Integrated Security=True";
            try
            {
                conexion.ConnectionString = datos;
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public static void Conectar(string baseDeDatos)
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"DataSourse = ALMA-PC\SQLEXPRESS;Initial Catalog=" + baseDeDatos + ";Integrated Security=True";
            conexion.Open();
        }
        public static SqlDataReader Buscar(string Tabla, string Regstro, string campo)
        {
            string cadenaSQL = "Select= * form " + Tabla + " where " + campo + "='" + Regstro + "' ";
            comando = new SqlCommand(cadenaSQL, conexion);
            conexion.Open();
            leer = comando.ExecuteReader();
            conexion.Close();
            return leer;
        }
        public static bool Insertar(List<string> valor)
        {
            try
            {
                string cadenaSQL = Delegados.insertar();
                string valores = "('";
                for (int j = 0; j < valor.Count; j++)
                {
                    valores = valores + valor[j] + "', '";
                }
                char[] c;
                c=valores.ToCharArray();
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

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }


        }
        public static bool Eliminar(string Tabla, string Registro, string campo)
        {
            try
            {

                conexion.Open();

                string cadenaSQL = "delete form " + Tabla + " where " + campo + "='" + Registro + "' ";
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
        public static bool Cambiar(string Tabla, string Registro, string campo)
        {
            try
            {

                conexion.Open();

                string cadenaSQL = "update" + Tabla + " set " + campo + " where ID= '" + Registro + "' ";
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
            string cadenaSQL = "Select= * form " + Tabla + "' ";
            adaptador = new SqlDataAdapter(cadenaSQL, conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, Tabla);
            DataTable dt = ds.Tables[Tabla];
            return dt;

        }
    }
    public delegate string CadenaSQL();
    public static class Delegados
    {
        public static CadenaSQL insertar = delegate { return "insert into TRB_ESPECIE (CLAVE, NCIENT, NCOMUN, COLOR,TALLA,PESO,T_AIMENTACION, VIDA_PROM, TIEMPO_GEST,ULT_ACT ) values "; };
    }
    public class AgregarDefaults
    {
        public AgregarDefaults()
        {
            List<Especie> Especies = new List<Especie>();
            Especies.Add(new Especie("Rorcual aliblanco", "Balaenoptera acutorostrata", "banda clara en forma de V invertida por detrás de la cabeza y una mancha blanca en las aletas pectorales",/*
           */"Tiene el cuerpo compacto, la cabeza en punta, angosta y triangular, con una quilla o cresta característica de los rorcuales Minke. Las aletas pectorales son delgadas y acabadas en punta. La aleta dorsal es alta y falcada," +/*
            */" ubicada en el tercio posterior del dorso. La aleta caudal posee lóbulos distales largos y finos. La coloración es oscura en cabeza, dorso y región dorsal de la aleta caudal, blanca en la región ventral y parte inferior de las aletas " +/*
            */"pectorales y gris en los flancos, pedúnculo caudal y parte superior de las aletas pectorales. Tiene una mancha blanca en las aletas pectorales y bandas claras en forma de V invertida por detrás de la cabeza y orificios respiratorios.\n " +/*
            */"Presenta de 30 a 70 pliegues gulares que se extienden hasta el final de las aletas pectorales. Posee de 231 a 360 barbas en cada mandíbula superior, de tonalidades blancoamarillentas a grises, de hasta 27 cm de longitud.", "Crill", 8.25,7.5, 60, 11.5));
            Especies.Add(new Especie("Rorcual de Rudolphi", "Balaenoptera borealis", "Color gris oscuro en el dorso y gris claro a blanco en el vientre", "La aleta dorsal está un poco más adelante que en la mayoría de los rorcuales, pero igualmente en la mitad posterior del dorso." +/**/
                "La cola es gruesa y la aleta caudal pequeña en relación al cuerpo.", "Bacalao", 14, 25, 70, 11.5));
            Especies.Add(new Especie("Ballena de Bryde", "Balaenoptera brydei", "Gris oscuro con una zona más clara en la garganta y vientre que se extiende hacia los flancos laterales.", "Esta ballena es muy parecida a la Sei, siendo confundidas comúnmente. Sin embrago la ballena de Bryde es" +/*
            */" generalmente mas corta y gruesa. Tiene la aleta dorsal falcada y bien definida. La pigmentación de la piel es gris oscura con una zona más clara en la garganta y vientre que se extiende hacia los flancos laterales. Tiene dos líneas extras o \"carenas\" en la cabeza (los otros " +/*
            */"rorcuales sólo tienen una central). Tiene entre 40 y 70 pliegues gulares generalmente posteriores al ombligo y 500 a 730 barbas que pueden llegar medir 60 cm.", "Se alimenta de pequeños peces y crustáceos.", 13, 16, 0, 0));
            Especies.Add(new Especie("Ballena Azul", "Balaenoptera musculus", "Gris con pequeñas manchas claras a lo largo del cuerpo que reflejan mas luz y hacen la ballena se vea azul cuando está debajo del agua", "Esta es una ballena grande y delgada, con una pequeña aleta dorsal. La pigmentación" +/*
            */" de la piel es gris con pequeñas manchas claras a lo largo del cuerpo que reflejan mas luz y hacen la ballena se vea azul cuando está debajo del agua. Tiene entre 58 y 88 pliegues gulares y 540 a 790 barbas que pueden llegar a medir 1m de largo.", "Zooplankton", 25.5, 210, 80, 0));





            List<Region> Regiones = new List<Region>();
            Regiones.Add(new Region("asd", "Bahia de la paz", "Tengo sueño, lo haré despues", "Solo por no dejarlo vacio", 30, 30, 300, 3));
            Regiones.Add(new Region("ase", "Laguna San Ignacio", "Tengo sueño2, lo haré despues2", "Solo por no dejarlo vacio2", 40, 35, 450, 3));
            Regiones.Add(new Region("asf", "ojo de liebre", "Tengo sueño, lo haré ", "Solo por no  vacio", 20, 35, 350, 3));

            /*foreach (Especie e in Especies)
            {
                e.Guardad();

            }*/
            foreach (Region e in Regiones)
            {
                e.Guardad();

            }

        }

    }
    public abstract class Registro
    {
        protected int id;
        protected DateTime ultAt;

        public Registro(DateTime ua)
        {
            id = 0;
            ultAt = ua;

        }

    }
    public class Usuario : Registro
    {
        string password, nombre, apellido, usuario, título;
        int especie, lugar;
        bool activo;
        public Usuario(string usr, string pwd, string nom, string apll)
            : base(DateTime.Today)
        {
            usuario = usr;
            password = pwd;
            nombre = nom;
            apellido = apll;
            activo = true;

        }
        public Usuario(string usr, string pwd, string nom, string apll, string titulo)
            : base(DateTime.Today)
        {
            usuario = usr;
            password = pwd;
            nombre = nom;
            apellido = apll;
            título = titulo;
            activo = true;

        }

        public int Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public bool Agregar()
        {
            Delegados.insertar = delegate { return "insert into TRB_ESPECIE (USR, PWD,TIT,NOM,APLL,ID_ESPECIE,ID_REGION, ACTIVO,ULT_ACT) values "; };
            List<string> valores = new List<string>();
            valores.Add(usuario); valores.Add(password); valores.Add(título); valores.Add(nombre);
            valores.Add(apellido); valores.Add(Especie.ToString()); valores.Add(Lugar.ToString());
            valores.Add("true"); valores.Add(base.ultAt.ToString());


            return ParaConectar.Insertar(valores);
        }

        public bool Actualizar(string Registro, string campo)
        {
            string tabla = "TRB_ESPECIE";
            return ParaConectar.Cambiar(tabla, Registro, campo);

        }

    }
    class Especie : Registro
    {
        string clave, nombreComun, nombreCientifico, color, descripcionMorfología, tipoAlimentacion;
        double tallaPromedio, pesoPromedio, añosPromedio_Vida, mesesGestación;
        public Especie(string común, string científico, string clr, string Descripcion, string alimentacion, double talla, double peso, double vida, double gestacion)
            : base(DateTime.Today)
        {
            nombreComun = común;
            nombreCientifico = científico;
            color = clr;
            descripcionMorfología = Descripcion;
            tipoAlimentacion = alimentacion;
            tallaPromedio = talla;
            pesoPromedio = peso;
            añosPromedio_Vida = vida;
            mesesGestación = gestacion;
            clave = base.id + nombreComun;


        }

        public bool Guardad()
        {
            Delegados.insertar = delegate { return "insert into TRB_ESPECIE (CLAVE, NCIENT, NCOMUN, COLOR,TALLA,PESO,T_ALIMENTACION, VIDA_PROM, TIEMPO_GEST,ULT_ACT ) values "; };
            List<string> valores = new List<string>();
            valores.Add(clave); valores.Add(nombreCientifico); valores.Add(nombreComun); valores.Add(color);
            valores.Add(tallaPromedio.ToString()); valores.Add(pesoPromedio.ToString()); valores.Add(tipoAlimentacion);
            valores.Add(añosPromedio_Vida.ToString()); valores.Add(mesesGestación.ToString()); valores.Add(base.ultAt.ToString());


            return ParaConectar.Insertar(valores);

        }
        public bool Actualizar(string Registro, string campo)
        {
            string tabla = "TRB_ESPECIE";
            return ParaConectar.Cambiar(tabla, Registro, campo);

        }
    }
    class Region : Registro
    {
        string clave, descripcion, ubicación, alimentos;
        int clima;
        double tempAguaCentígrados, profundidadMáxima, área;
        public Region(string Clave, string ubi, string Descripcion, string aliment, double temp, double prof, double area, int clima)
            : base(DateTime.Today)
        {
            clave = Clave;
            descripcion = Descripcion;
            ubicación = ubi;
            alimentos = aliment;
            this.clima = clima;
            tempAguaCentígrados = temp;
            profundidadMáxima = prof;
            área = area;



        }
        public bool Guardad()
        {
            Delegados.insertar = delegate { return "insert into TRB_REGION (CLAVE, DESCR, UBICACION, CLIMA,TEMP_AGUA,PROFUNDIDAD,T_ALIMENTACION, ULT_ACT ) values "; };
            List<string> valores = new List<string>();
            valores.Add(clave); valores.Add(descripcion); valores.Add(ubicación); valores.Add(clima.ToString());
            valores.Add(tempAguaCentígrados.ToString()); valores.Add(profundidadMáxima.ToString()); valores.Add(alimentos);
            valores.Add(base.ultAt.ToString());


            return ParaConectar.Insertar(valores);

        }
        public bool Actualizar(string Registro, string campo)
        {
            string tabla = "TRB_REGION";
            return ParaConectar.Cambiar(tabla, Registro, campo);

        }

    }
}
