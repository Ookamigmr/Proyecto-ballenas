using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConexiónSQL
{
   public  class AgregarDefaults
    {
        public AgregarDefaults()
        {
            List<Especie> Especies = new List<Especie>();
            Especies.Add(new Especie("Rorcual aliblanco","Balaenoptera acutorostrata","banda clara en forma de V invertida por detrás de la cabeza y una mancha blanca en las aletas pectorales",/*
           */"Tiene el cuerpo compacto, la cabeza en punta, angosta y triangular, con una quilla o cresta característica de los rorcuales Minke. Las aletas pectorales son delgadas y acabadas en punta. La aleta dorsal es alta y falcada,"+/*
            */" ubicada en el tercio posterior del dorso. La aleta caudal posee lóbulos distales largos y finos. La coloración es oscura en cabeza, dorso y región dorsal de la aleta caudal, blanca en la región ventral y parte inferior de las aletas "+/*
            */"pectorales y gris en los flancos, pedúnculo caudal y parte superior de las aletas pectorales. Tiene una mancha blanca en las aletas pectorales y bandas claras en forma de V invertida por detrás de la cabeza y orificios respiratorios.\n "+/*
            */"Presenta de 30 a 70 pliegues gulares que se extienden hasta el final de las aletas pectorales. Posee de 231 a 360 barbas en cada mandíbula superior, de tonalidades blancoamarillentas a grises, de hasta 27 cm de longitud.","Crill",8.25,7.5,60,11.5));
            Especies.Add(new Especie("Rorcual de Rudolphi", "Balaenoptera borealis", "Color gris oscuro en el dorso y gris claro a blanco en el vientre", "La aleta dorsal está un poco más adelante que en la mayoría de los rorcuales, pero igualmente en la mitad posterior del dorso." +/**/
                "La cola es gruesa y la aleta caudal pequeña en relación al cuerpo.", "Bacalao", 14, 25, 70, 11.5));
            Especies.Add(new Especie("Ballena de Bryde","Balaenoptera brydei","Gris oscuro con una zona más clara en la garganta y vientre que se extiende hacia los flancos laterales.","Esta ballena es muy parecida a la Sei, siendo confundidas comúnmente. Sin embrago la ballena de Bryde es"+/*
            */" generalmente mas corta y gruesa. Tiene la aleta dorsal falcada y bien definida. La pigmentación de la piel es gris oscura con una zona más clara en la garganta y vientre que se extiende hacia los flancos laterales. Tiene dos líneas extras o \"carenas\" en la cabeza (los otros "+/*
            */"rorcuales sólo tienen una central). Tiene entre 40 y 70 pliegues gulares generalmente posteriores al ombligo y 500 a 730 barbas que pueden llegar medir 60 cm.","Se alimenta de pequeños peces y crustáceos.",13,16,0,0));
            Especies.Add(new Especie("Ballena Azul", "Balaenoptera musculus", "Gris con pequeñas manchas claras a lo largo del cuerpo que reflejan mas luz y hacen la ballena se vea azul cuando está debajo del agua", "Esta es una ballena grande y delgada, con una pequeña aleta dorsal. La pigmentación" +/*
            */" de la piel es gris con pequeñas manchas claras a lo largo del cuerpo que reflejan mas luz y hacen la ballena se vea azul cuando está debajo del agua. Tiene entre 58 y 88 pliegues gulares y 540 a 790 barbas que pueden llegar a medir 1m de largo.", "Zooplankton", 25.5, 210, 80, 0));





            List<Region> Regiones = new List<Region>();
            Regiones.Add(new Region("asd", "Bahia de la paz", "Tengo sueño, lo haré despues", "Solo por no dejarlo vacio", 30, 30, 300, 3));
            Regiones.Add(new Region("ase", "Laguna San Ignacio", "Tengo sueño2, lo haré despues2", "Solo por no dejarlo vacio2", 40, 35, 450, 3));
            Regiones.Add(new Region("asf", "ojo de liebre", "Tengo sueño, lo haré ", "Solo por no  vacio", 20, 35, 350, 3));

            foreach (Especie e in Especies)
            {
                e.Guardad();
               
            }
            foreach (Region  e in Regiones )
            { 
                e.Guardad();

            }

        }

    }
}
