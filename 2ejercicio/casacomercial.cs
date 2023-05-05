using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ejercicio
{
    class casacomercial
    {
        string nombre;
        string email;
        int total;
        List<vehiculo> v;

        public casacomercial(string nombre, string email, int total, List<vehiculo> v)
        {
            this.nombre = nombre;
            this.email = email;
            this.total = total;
            this.v = v;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Total { get => total; set => total = value; }
        internal List<vehiculo> V { get => v; set => v = value; }

        public void AnadirVehiculo(vehiculo vehiculo)
        {
            try
            {

                this.v.Add(vehiculo);

                this.Total += 1;
                Console.WriteLine("Se ha añadido un nuevo vehiculo\n");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo añadir debido a: {0}", ex.Message);
                Console.ReadLine();
            }
        }
        public void Mostrarvehiculos()
        {
            foreach (var n in this.v)
            {
                Console.WriteLine(n.ToString());

            }
        }
        public void VaciarVehiculo()
        {
            Console.WriteLine("Estas seguro que desea vaciar los elementos mostrados en la lista: S/N");
            string resp = Console.ReadLine();
            if (resp == "S" || resp == "s")
            {
                v = new List<vehiculo>();
                this.Total = 0;
                Console.WriteLine("Se ha eliminado todos los elementos");
            }
            else
            {
                Console.WriteLine("No se elimino, Hay {0} vehiculo registrado", Total);
                Console.ReadKey();
            }
        }
        public void EliminarVehiculo(vehiculo vehiculo)
        {
            if (v.Count>0)
            {
                v.Remove(vehiculo);
                Total -= 1;
                Console.WriteLine("Se ha eliminado un registro");
            }
            else
                Console.WriteLine("No hay elementos que eliminar en la lista");
            Console.ReadKey();
        }
    }
}
