using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e3ejercicio
{
    class Program
    {
        static void pedir(string m, out int n)
        {
            Console.WriteLine(m);
            n = int.Parse(Console.ReadLine());
        }
        static void menu()
        {
            Console.WriteLine("\n\n\tMENU\n");
            Console.WriteLine("1.encender la computadora");
            Console.WriteLine("2.anadir un dato");
            Console.WriteLine("3.eliminar un dato");
            Console.WriteLine("4.apagart la computadora");
            Console.WriteLine("5.salir");
        }
        static void ejecutar(computadora cp)
        {
            int opc;
            do
            {
                int dato;
                menu();
                pedir("de la opcion: ", out opc);
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        cp.enceder(); break;
                    case 2:
                        pedir("de el tamaño del dato: ", out dato);
                        cp.añadirDato(dato);
                        break;
                    case 3:
                        pedir("de el tamaño del dato a eliminar: ", out dato);
                        cp.eliminarDato(dato);
                        break;
                    case 4:
                        cp.apagado();
                        break;
                    case 5:
                        Console.WriteLine("saliendo...");
                        break;
                    default:
                        Console.WriteLine("opcion fuera del rango");
                        break;
                }
            }
            while (opc != 5);
        }
        static void Main(string[] args)
        {
            computadora cp = new computadora(0, 200, false);
            ejecutar(cp);
            Console.ReadKey();
        }
    }
}
