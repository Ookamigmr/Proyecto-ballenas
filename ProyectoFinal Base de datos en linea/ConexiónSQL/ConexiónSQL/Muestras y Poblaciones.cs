using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConexiónSQL
{
    public class Ballena:Registro

    {
        public string clave, alias;
        bool sexo;
        int fechaNacimiento;
        public int etapaCrecimiento, idEspecie, idPoblación;//1-cria 4- juvenil 5-adulto
        double tamaño;
        public Ballena(string Clave,  bool  Sex, double tam,int etapa, int especie, int poblacion, int nacimiento)
            : base(DateTime.Today)
        {
            clave = Clave;
            tamaño = tam;
            sexo = Sex;
            fechaNacimiento = nacimiento ;
            etapaCrecimiento = etapa;
            idEspecie = especie;
            idPoblación = poblacion;

        }
        public Ballena(string Clave, bool Sex, int etapa, int especie, int poblacion)
            : base(DateTime.Today)
        {
            clave = Clave;

            sexo = Sex;
            etapaCrecimiento = etapa;
            idEspecie = especie;
            idPoblación = poblacion;

        }
       public Ballena( bool Sex, double tam,int etapa, int especie, int poblacion)
            : base(DateTime.Today)
        {
            clave = especie.ToString() + poblacion.ToString() + DateTime.Today.Year +ParaConectar.ObtenerValorParaClave ("TRB_MUESTRAS").ToString() + Delegados.paraCalves.ToString();
            Delegados.paraCalves++;
            tamaño = tam;
            sexo = Sex;
            etapaCrecimiento = etapa;
            idEspecie = especie;
            idPoblación = poblacion;

        }
       public Ballena(bool Sex, double tam, int etapa, int especie, int poblacion, int nacimiento)
           : base(DateTime.Today)
       {
           clave = especie.ToString() + poblacion.ToString() + DateTime.Today.Year + ParaConectar.ObtenerValorParaClave("TRB_MUESTRAS").ToString() + Delegados.paraCalves.ToString();
           Delegados.paraCalves++;
           tamaño = tam;
           sexo = Sex;
           fechaNacimiento = nacimiento ;
           etapaCrecimiento = etapa;
           idEspecie = especie;
           idPoblación = poblacion;

       }
        public void AgregarAlias(string Alias)
        {
            alias = Alias;
        }
        public bool Guardad()
        {
            Delegados.insertar = delegate { return "insert into TRB_MUESTRAS (CLAVE, ALIAS, SEXO, ANO_NAC,TAMANO,ID_EVIDA,ID_ESPECIE, ID_POBLACION, ULT_ACT ) values "; };
            List<string> valores = new List<string>();
            valores.Add(clave); valores.Add(alias); valores.Add(sexo.ToString()); valores.Add(fechaNacimiento.ToString());
            valores.Add(tamaño.ToString()); valores.Add(etapaCrecimiento.ToString()); valores.Add(idEspecie. ToString());
            valores.Add(idPoblación.ToString());  valores.Add(base.ultAt.ToString());


            return ParaConectar.Insertar(valores);

        }
        public bool Actualizar(string Registro, string campo)
        {
            string tabla = "TRB_MUESTRAS";
            return ParaConectar.Cambiar(tabla, Registro, campo);

        }


    }


    public class Poblacion : Registro
    {
        public string clave;// Clave = AñoMesDiaEspecieRegion    00 00 00 00 00
        public int n_población, id_visita, id_región, id_especie, id, registrados;
        public DateTime fechaLlegada, fechaSalida;
        public string notas;
        public Poblacion( DateTime llegada, int region, int especie)
            : base(DateTime.Today)
        {

            clave = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + especie.ToString() + region.ToString() + ParaConectar.ObtenerValorParaClave("TRB_REGISTRO").ToString() + Delegados.paraCalves.ToString();
            Delegados.paraCalves++;
            fechaLlegada = llegada;
            id_región = region;
            id_especie = especie;

        }
        public Poblacion(DateTime llegada, int region, int especie, string Clave, int individuos, string Notas)
            : base(DateTime.Today)
        {

            clave = Clave;
            notas = Notas;
            fechaLlegada = llegada;
            id_región = region;
            id_especie = especie;
            n_población = individuos;

        }
        public Poblacion(DateTime llegada, int region, int especie, string Clave, int individuos, string Notas,DateTime fechaSal)
            : base(DateTime.Today)
        {
            notas = Notas;
            clave = Clave;

            fechaLlegada = llegada;
            id_región = region;
            id_especie = especie;
            n_población = individuos;
            fechaSalida = fechaSal;
        }
        public bool Actualizar(string Registro, string campo)
        {
            string tabla = "TRB_REGISTRO";

                return ParaConectar.CambiarConClave(tabla, Registro, campo);

        }
        public void AgregarNumero(int numero)
        {
            n_población = numero;
            string campo =  " N_POBLACION='" + numero.ToString() + "', ULT_ACT='" + DateTime.Today.ToString() + "'";
            Actualizar(clave, campo);
        }
        public void AgregarNota(string nota)
        {
            notas  = nota;
            string campo = " NOTAS='" + nota.ToString() + "', ULT_ACT='" + DateTime.Today.ToString() + "'";
            Actualizar(clave, campo);
        }
        public void Despachar(DateTime  FechaSalida)
        {
            fechaSalida  = FechaSalida;
            string campo = " FEC_FIN='" + fechaSalida.ToString() + "', ULT_ACT='" + DateTime.Today.ToString() + "'";
            Actualizar(clave, campo);
        }
        public bool Guardad()
        {
            Delegados.insertar = delegate { return "insert into TRB_REGISTRO (CLAVE, FEC_INI, ID_REGION, ID_ESPECIE, ULT_ACT ) values "; };
            List<string> valores = new List<string>();
            valores.Add(clave); valores.Add(fechaLlegada.ToString()); valores.Add(id_región. ToString());
            valores.Add(id_especie . ToString()); valores.Add(base.ultAt.ToString());


            return ParaConectar.Insertar(valores);

        }
    }


}
