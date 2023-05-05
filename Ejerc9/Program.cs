using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc9
{
    class Program
    {
        static void Main(string[] args)
        {
            Camionero cami = new Camionero(1, 1200, "calle 13", 234566, "Jose", "Mata", new Camion(1200, "12234", "loca", "lpo"), new List<Paquete>());
            Paquete pack = new Paquete(123, "paquete de luisa", "casa mokoron", "En el internado", new Ciudad(29292, "Managua"));
            cami.AgregarPack(pack);
            Console.ReadKey();
        }
    }
}
