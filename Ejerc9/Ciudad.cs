using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc9
{
    class Ciudad
    {
        int codigo;
        string nombre;

        public Ciudad(int codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
