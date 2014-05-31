using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConexiónSQL
{
    public abstract class Registro
    {
        protected  int id;
        protected  DateTime ultAt;

        public Registro(DateTime ua)
        {
            //id = 0;
            ultAt = ua;

        }

    }





    public class Usuario : Registro
    {
        string password, nombre, apellido, título;
        public string usuario;
        int especie, lugar;
        bool activo,admin;
        public Usuario(string usr, string pwd, string nom, string apll, bool ad)
            : base(DateTime.Today)
        {
            usuario = usr;
            password = pwd;
            nombre = nom;
            apellido = apll;
            activo = true;
            admin = ad;

        }
        public Usuario(string usr, string nom, string apll, int zona, int ballena)
            : base(DateTime.Today)
        {
            usuario = usr;
            especie = ballena;
            lugar = zona;
            nombre = nom;
            apellido = apll;
            activo = true;


        }
       public  Usuario(string usr, string pwd, string nom, string apll, string titulo, bool ad)
            : base(DateTime.Today)
        {
            usuario = usr;
            password = pwd;
            nombre = nom;
            apellido = apll;
            título = titulo;
            activo = true;
            admin = ad;

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
            Delegados.insertar = delegate { return "insert into TRB_USR (USR, PWD,TIT,NOM,APLL,ID_ESPECIE,ID_REGION, ACTIVO,ULT_ACT,[ADMIN]) values "; };
            List<string> valores = new List<string>();
            valores.Add("'"+usuario+"',"); valores.Add("'"+password+"',"); valores.Add("'"+título+"',"); valores.Add("'"+nombre+"',");
            valores.Add("'"+apellido+"',"); valores.Add(Especie.ToString()+","); valores.Add(Lugar.ToString()+",");
            valores.Add("'true',"); valores.Add("getdate(),");valores.Add("'"+admin.ToString()+"'");;


            return ParaConectar.Insertar(valores);
        }
        
        public bool Actualizar(string Registro, string campo)
        {
            string tabla = "TRB_USR";
            return ParaConectar.Cambiar(tabla, Registro, campo);

        }


    }
   
    
    
    
    
    
    public class Especie : Registro
    {
        string clave,nombreComun,nombreCientifico,color, descripcionMorfología, tipoAlimentacion;
        double tallaPromedio, pesoPromedio,añosPromedio_Vida, mesesGestación;
        public Especie(string común, string científico, string clr, string Descripcion, string alimentacion, double talla, double peso, double vida, double gestacion )
            :base (DateTime.Today)
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
        public void IngresarDatos(string común,  string clr, string Descripcion, string alimentacion, double talla, double peso, double vida, double gestacion)
            
        {
            nombreComun = común;
            
            color = clr;
            descripcionMorfología = Descripcion;
            tipoAlimentacion = alimentacion;
            tallaPromedio = talla;
            pesoPromedio = peso;
            añosPromedio_Vida = vida;
            mesesGestación = gestacion;
          


        }
       
       public bool Guardad()
        {
            List<string> valores = new List<string>();
            if (string.IsNullOrEmpty(descripcionMorfología))
            {
                Delegados.insertar = delegate { return "insert into TRB_ESPECIE (CLAVE, NCIENT, NCOMUN,COLOR,TALLA,PESO,T_ALIMENTACION, VIDA_PROM, TIEMPO_GEST,ULT_ACT ) values "; };

                valores.Add(clave); valores.Add(nombreCientifico); valores.Add(nombreComun); valores.Add(color);
                valores.Add(tallaPromedio.ToString()); valores.Add(pesoPromedio.ToString()); valores.Add(tipoAlimentacion);
                valores.Add(añosPromedio_Vida.ToString()); valores.Add(mesesGestación.ToString()); valores.Add(base.ultAt.ToString());

            }
            {
                Delegados.insertar = delegate { return "insert into TRB_ESPECIE (CLAVE, NCIENT, NCOMUN, CMORFOLOGIA,COLOR,TALLA,PESO,T_ALIMENTACION, VIDA_PROM, TIEMPO_GEST,ULT_ACT ) values "; };

                valores.Add(clave); valores.Add(nombreCientifico); valores.Add(nombreComun); valores.Add(descripcionMorfología); valores.Add(color);
                valores.Add(tallaPromedio.ToString()); valores.Add(pesoPromedio.ToString()); valores.Add(tipoAlimentacion);
                valores.Add(añosPromedio_Vida.ToString()); valores.Add(mesesGestación.ToString()); valores.Add(base.ultAt.ToString());
            }

            return ParaConectar.Insertar(valores);

        }
        public bool  Actualizar(string Registro, string campo)
        {
            string tabla = "TRB_ESPECIE";
            return ParaConectar.Cambiar(tabla, Registro, campo);

        }
        public bool  ActualizarTodo()
        {
            string tabla = "TRB_ESPECIE";
            int id = ParaConectar.ObtenerID(tabla, clave);
            string campo = "CMORFOLOGIA='" +descripcionMorfología  +"', NCOMUN= '" + nombreComun + "', COLOR='" + color + "', TALLA='" + tallaPromedio + "', PESO ='" + pesoPromedio + "', T_ALIMENTACION='" + tipoAlimentacion + "', VIDA_PROM='" + añosPromedio_Vida + "', TIEMPO_GEST='" + mesesGestación + "', ULT_ACT='" + DateTime.Today.ToString() + "'";

           
            return ParaConectar.Cambiar(tabla, id.ToString(), campo );
        }
    }
    
    
    
    
    
    
    public class Region : Registro
    {
        string clave, descripcion, ubicación, alimentos;
        int clima;
        double tempAguaCentígrados, profundidadMáxima, área;
        public Region(string Clave, string ubi, string Descripcion, string aliment, double temp, double prof, double area, int clima )
            :base (DateTime.Today)
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
            valores.Add(clave); valores.Add(descripcion ); valores.Add(ubicación ); valores.Add(clima.ToString() );
            valores.Add(tempAguaCentígrados.ToString()); valores.Add(profundidadMáxima.ToString()); valores.Add(alimentos );
             valores.Add(base.ultAt.ToString());
           

            return ParaConectar.Insertar(valores);

        }
        public bool Actualizar(string Registro, string campo)
        {
            string tabla = "TRB_REGION";
            return ParaConectar.Cambiar(tabla, Registro, campo);

        }
        public bool ActualizarTodo()
        {
            string tabla = "TRB_REGION";
            int id = ParaConectar.ObtenerID(tabla, clave);
            string campo = "DESCR= '" + descripcion  + "', UBICACION='" + ubicación  + "', CLIMA='" + clima  + "', TEMP_AGUA ='" + tempAguaCentígrados  + "', PROFUNDIDAD='" + profundidadMáxima  + "', T_ALIMENTACION='" + alimentos  +"', ULT_ACT='" + DateTime.Today.ToString() + "'";
           

            return ParaConectar.Cambiar(tabla, id.ToString(), campo);
        }

    }
}
