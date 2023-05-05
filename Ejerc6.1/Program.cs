using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangulo rec = new Rectangulo(6, 6);
            Circulo cir = new Circulo(3);
            rec.coordenada = new Ubicacion(3, 3);
            rec.CalPerimetro();
            rec.CalArea();
            Console.WriteLine(rec.ToString());
            cir.coordenada = new Ubicacion(8, 9);
            cir.CalPerimetro();
            cir.CalArea();
            Console.WriteLine(cir.ToString());

            Console.ReadKey();
        }
    }
}
