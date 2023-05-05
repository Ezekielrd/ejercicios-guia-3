using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e3ejercicio
{
    class computadora
    {
        int capacidadDisco;
        int espacioDispinible;
        bool on;

        public computadora(int cpacidadDisco, int espacioDispinible, bool on)
        {
            this.CapacidadDisco = cpacidadDisco;
            this.EspacioDispinible = espacioDispinible;
            this.On = on;
        }

        public int CapacidadDisco { get => capacidadDisco; set => capacidadDisco = value; }
        public int EspacioDispinible { get => espacioDispinible; set => espacioDispinible = value; }
        public bool On { get => on; set => on = value; }

        public void añadirDato(int dato)
        {
            if (on)
            {
                if (dato < espacioDispinible)
                {
                    this.capacidadDisco += dato;
                    Console.WriteLine("el dato se ha añadido");
                }
            }
            else
            {
                Console.WriteLine("la computadora esta apagada");
            }
        }

        public void eliminarDato(int dato)
        {
            if (on)
            {
                if (dato < capacidadDisco)
                {
                    capacidadDisco -= dato;
                    Console.WriteLine("se ha elimida el dato");
                }
                else
                {
                    Console.WriteLine("el dato es mayor a lo almcanado en el disco");
                }
            }
            else
            {
                Console.WriteLine("la computadora apagada");
            }
        }
        public void enceder()
        {
            this.on = true;
            Console.WriteLine("welcome");
        }
        public void apagado()
        {
            this.on = false;
            Console.WriteLine("bye");
        }
    }
}
