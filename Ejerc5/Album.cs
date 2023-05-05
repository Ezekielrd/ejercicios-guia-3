using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc5
{
    class album
    {
        int id;
        string nombre;
        DateTime fechC;
        List<Fotos> alb;

        public album(int id, string nombre, DateTime fechC, List<Fotos> alb)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechC = fechC;
            this.alb = alb;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechC { get => fechC; set => fechC = value; }
        internal List<Fotos> Alb { get => alb; set => alb = value; }

        public void añadirFoto(Fotos f)
        {
            this.alb.Add(f);
            Console.WriteLine("se ha añadido una foro al album");

        }
        public void mostrarFoto()
        {
            foreach (var n in alb)
            {
                Console.WriteLine(n.ToString());
            }
        }
        public void vaciarAlbum()
        {
            Console.WriteLine("esta seguro de vaciar el album: ");
            string rep = Console.ReadLine();
            if (rep == "s" || rep == "S")
            {
                alb = new List<Fotos>();
                Console.WriteLine("se ha vaciado el album");
            }
        }
        public void eliminarFoto(Fotos f)
        {
            if (alb.Count > 0)
            {
                this.alb.Remove(f);
                Console.WriteLine("se ha eliminado la foto");
            }
            else
            {
                Console.WriteLine("no hay fotos que eliminar");
            }
        }
        public void tamañoAlbum()
        {
            int suma = 0;
            foreach (var n in this.alb)
            {
                suma += n.Tam;
            }
            Console.WriteLine("El tamaño del album es: {0}", suma);
        }
    }
}
