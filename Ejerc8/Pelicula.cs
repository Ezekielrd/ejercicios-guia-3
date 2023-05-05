using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc8
{
    class Pelicula
    {
        string nombre;
        int anio;
        private List<Actor> actores;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Anio { get => anio; set => anio = value; }
        internal List<Actor> Actores { get => actores; set => actores = value; }

        public Pelicula(string nombre, int anio, List<Actor> actores)
        {
            this.Nombre = nombre;
            this.Anio = anio;
            this.Actores = actores;
        }
        public void AgregarActor(Actor actor)
        {
            Actores.Add(actor);
        }
    }
}
   
