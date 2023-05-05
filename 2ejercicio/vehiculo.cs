using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ejercicio
{
    class vehiculo
    {
        int Id;
        string Marca;
        string Modelo;
        int KM;
        decimal Precio;
        int Año;

        public vehiculo(int id, string marca, string modelo, int kM, decimal precio, int año)
        {
            this.Id1 = id;
            this.Marca1 = marca;
            this.Modelo1 = modelo;
            this.KM1 = kM;
            this.Precio1 = precio;
            this.Año1 = año;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public int KM1 { get => KM; set => KM = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }
        public int Año1 { get => Año; set => Año = value; }

        public override string ToString()
        {
            return "Modelo: " + Modelo + "\n" + "Marca: " + Marca + "\n" + "Kilometraje: " + KM + "\n" + "Precio: " + Precio + "\n" + "Año: " + Año;
        }
    }
}
