using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc6._1
{
    class Circulo:Forma
    {
        protected double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        protected double Radio { get => radio; set => radio = value; }

        public override double CalArea()
        {
            Area = Math.PI * (radio * 2);
            return base.CalArea();
        }

        public override double CalPerimetro()
        {
            Perimetro = (2 * Math.PI) * radio;
            return base.CalPerimetro();
        }
    }
}
