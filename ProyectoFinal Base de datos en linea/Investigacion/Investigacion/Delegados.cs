using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexiónSQL;

namespace Grupos
{
    public delegate void RecibeNada_EntregaNada();
    public delegate void RecibeEntero_EntregaNada(int q);
    public delegate Poblacion   EntregaPoblacion();
    public delegate Usuario EntregaUsuario();
    public delegate  UserControl  EntregaUserControl();
    public static class Delegados
    {
        public static RecibeNada_EntregaNada Accion, pequeñaAccion;
        public static RecibeEntero_EntregaNada llenarConEntero;
        public static EntregaUsuario UsuarioEnCuestión;
        public static EntregaUserControl UserControlSiguiente;
        public static EntregaPoblacion ePoblacion;
    }
}
