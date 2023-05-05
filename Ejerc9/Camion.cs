using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc9
{
    class Camion
    {
        int potencia;
        string matricula;
        string modelo;
        string tipo;

        public Camion(int potencia, string matricula, string modelo, string tipo)
        {
            this.Potencia = potencia;
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.Tipo = tipo;
        }

        public int Potencia { get => potencia; set => potencia = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
