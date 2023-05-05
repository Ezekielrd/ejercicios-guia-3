using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc9
{
    class Camionero
    {
        int rec;
        double salario;
        string direccion;
        int telefono;
        string nombre;
        string poblacion;
        Camion Eze;
        List<Paquete> pack;

        public Camionero(int rec, double salario, string direccion, int telefono, string nombre, string poblacion, Camion eze, List<Paquete> pack)
        {
            this.Rec = rec;
            this.Salario = salario;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Nombre = nombre;
            this.Poblacion = poblacion;
            this.Eze1 = eze;
            this.Pack = pack;
        }

        public int Rec { get => rec; set => rec = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        internal Camion Eze1 { get => Eze; set => Eze = value; }
        internal List<Paquete> Pack { get => pack; set => pack = value; }

        public void AgregarPack(Paquete p)
        {
            this.pack.Add(p);
            Console.WriteLine("Se ha agregado un paquete");
        }
    }
}
