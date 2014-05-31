using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elementos
{
    public abstract class   Registro
    {
        int id;
        DateTime ultAt;
        
        public Registro(DateTime ua)
        {
            id = 0;
            ultAt = ua;

        }

    }
    public class Usuario: Registro 
    {
        string password, nombre, apellido, usuario;
        int especie, lugar;
        bool activo;
        Usuario(string usr, string pwd, string nom, string apll)
            : base(DateTime.Today)
        {
            usuario = usr;
            password = pwd;
            nombre = nom;
            apellido = apll;
            activo = true;

        }

        public int Especie
        {
            get { return especie ; }
            set { especie  = value; }
        }

        public int Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        





    }
}
