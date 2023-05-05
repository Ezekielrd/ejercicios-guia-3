using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc7
{
    class persona
    {
        string nombre;
        public persona(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return $"nombre: {nombre}";
        }
    }
}
