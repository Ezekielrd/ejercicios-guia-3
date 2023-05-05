using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            casacomercial cas = new casacomercial("pellas", "pll@gmail.com",0,new List<vehiculo>());
            vehiculo vh = new vehiculo(01,"totyota","nissan",5000,12000,2015);
            cas.AnadirVehiculo(vh);
            cas.Mostrarvehiculos();
            cas.VaciarVehiculo();
            cas.EliminarVehiculo(vh);
            Console.ReadKey();
        }
    }
}
