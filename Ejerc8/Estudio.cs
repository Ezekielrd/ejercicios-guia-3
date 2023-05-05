using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc8
{
    class Estudio
    {
        string nombre;
        string direccion;
        List<Pelicula> peliculas;

        public Estudio(string nombre, string direccion, List<Pelicula> peliculas)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Peliculas = peliculas;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Pelicula> Peliculas { get => peliculas; set => peliculas = value; }
        public void AgregarPelicula(Pelicula peli)
        {
            peliculas.Add(peli);
        }
    }
}
