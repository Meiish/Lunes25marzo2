using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Triangulo : Figura
    {
        private float b;
        private float h;

        public Triangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        public override float ReturnArea()
        {
            return b * h / 2;
        }
    }
}
