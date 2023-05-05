using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc6._1
{
    class Forma
    {
        public double area;
        public double perimetro;
        public Ubicacion coordenada;

        public double Area { get => area; set => area = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }

        public virtual double CalArea()
        {
            return Area;
        }

        public virtual double CalPerimetro()
        {
            return Perimetro;
        }

        public override string ToString()
        {
            return "Area: " + Area + "\n" + "Perimetro: " + Perimetro;
        }
    }
}

