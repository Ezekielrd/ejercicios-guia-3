using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            album alb = new album(1, "Recuerdos de mi viaje", new DateTime(2015, 10, 20), new List<Fotos>());
            Fotos f1 = new Fotos(1, 20, new DateTime(2013, 12, 24), "En Dubai");
            alb.añadirFoto(f1);
            alb.mostrarFoto();
            alb.tamañoAlbum();
            alb.vaciarAlbum();
            alb.eliminarFoto(f1);
            Console.ReadKey();
        }
    }
}
