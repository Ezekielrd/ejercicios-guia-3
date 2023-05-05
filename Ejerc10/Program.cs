using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc10
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona("Luis", 29);
            per.Mostrar();

            Cliente cli = new Cliente("Maria", 70, "89654321");
            cli.Mostrar();

            Empleado emp = new Empleado("Cenicienta", 24, 95000);
            emp.Mostrar();

            decimal salan = emp.CalcularSalarioNeto();
            Console.WriteLine("Salario neto: " + salan);

            Empresa empresa = new Empresa("Invercasa");

            Directivo direc = new Directivo("Marcos", 35, "Administrador general");
            direc.Mostrar();

            Console.ReadKey();
        }
    }
}
