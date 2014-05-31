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
   public  delegate UserControl aContinuación ();
    public delegate void eventos ();
    public static class Delegados
    {
        public static aContinuación SeñalUsuarios ;
        public static eventos evento, cerrar, cambiarPanel;
    }
    static class Eventos
    {
 
    }
}
