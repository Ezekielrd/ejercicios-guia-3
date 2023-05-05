using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc6._1
{
    class Ubicacion
    {
        private double x;
        private double y;

        public Ubicacion(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        private double X { get => x; set => x = value; }
        private double Y { get => y; set => y = value; }
    }
}
