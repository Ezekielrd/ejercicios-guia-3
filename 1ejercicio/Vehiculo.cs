using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ejercicio
{
    class Vehiculo
    {
        int Id;
        string Marca;
        string Modelo;
        int Km;
        decimal Precio;
        int Anio;

        public Vehiculo(int id, string marca, string modelo, int km, decimal precio, int anio)
        {
            Id1 = id;
            Marca1 = marca;
            Modelo1 = modelo;
            Km1 = km;
            Precio1 = precio;
            Anio1 = anio;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public int Km1 { get => Km; set => Km = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }
        public int Anio1 { get => Anio; set => Anio = value; }

        public override string ToString()
        {
            return $"Modelo: {Modelo1}\nMarca: {Marca1}\nKilometraje: {Km1}\nPrecio: {Precio1}\nAño: {Anio1} ";
        }
    }
}
