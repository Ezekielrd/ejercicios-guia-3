using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc6._1
{
    class Rectangulo : Forma
    {
        protected double lado1;
        protected double lado2;

        public Rectangulo(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        protected double Lado1 { get => lado1; set => lado1 = value; }
        protected double Lado2 { get => lado2; set => lado2 = value; }

        public override double CalArea()
        {
            Area = this.Lado1 * this.Lado2;
            return base.CalArea();
        }

        public override double CalPerimetro()
        {
            Perimetro = (2 * this.Lado1) + (2 * this.Lado2);
            return base.CalPerimetro();
        }
    }
}
