using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc10
{
     class Directivo : Persona
    {
        string Categoria { get; set; }
        public Directivo(string nombre, int edad, string categoria) : base(nombre, edad)
        {
            Categoria = categoria;
        }
        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Categoría: {Categoria}");
        }
    }
}
