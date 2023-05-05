using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc8
{
    class Actor
    {
        string nombre;
        string Apellido;

        public Actor(string nombre, string apellido)
        {
            this.nombre = nombre;
            Apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
    }
}
