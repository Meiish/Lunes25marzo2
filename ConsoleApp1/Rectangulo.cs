using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Rectangulo : Figura
    {
        private float b;
        private float h;

        public Rectangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        public override float ReturnArea()
        {
            return b * h;
        }
    }
}
