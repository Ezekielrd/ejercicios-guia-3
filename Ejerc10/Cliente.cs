using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc10
{
    class Cliente : Persona
    {
        public Cliente(string nombre, int edad, string numeroTelefono) : base(nombre, edad)
        {
            NumeroTelefono = numeroTelefono;
        }

        public string NumeroTelefono { get; set; }

        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Número de Teléfono: {NumeroTelefono}");
        }
    }
}
