using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConexiónSQL
{
    public  delegate string CadenaSQL ();
    public static class Delegados
    {
        public static CadenaSQL insertar = delegate { return "insert into TRB_ESPECIE (CLAVE, NCIENT, NCOMUN, COLOR,TALLA,PESO,T_AIMENTACION, VIDA_PROM, TIEMPO_GEST,ULT_ACT ) values "; };
       // public static CadenaSQL Actualizar = delegate { return "update TRB_ESPECIE set (CLAVE, NCIENT, NCOMUN, COLOR,TALLA,PESO,T_AIMENTACION, VIDA_PROM, TIEMPO_GEST,ULT_ACT ) values "; };
       // " " + Tabla + " set " + campo + " where ID= '" + Registro + "' "
        public static int paraCalves=0;
        
    }
}
