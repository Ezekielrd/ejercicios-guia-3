using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc10
{
    class Empleado : Persona
    {
        public Empleado(string nombre, int edad, decimal sueldoBruto) : base(nombre, edad)
        {
            SueldoBruto = sueldoBruto;
        }

        public decimal SueldoBruto { get; set; }

        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Sueldo Bruto: {SueldoBruto}");
        }

        public decimal CalcularSalarioNeto()
        {

            decimal seguro = SueldoBruto * 0.12m;
            decimal salarioneto = SueldoBruto - seguro;
            return salarioneto;
        }
    }

    public class Empresa
    {
        string Nombre;
        public Empresa(string nombre)
        {
            Nombre = nombre;
        }


    }
}
