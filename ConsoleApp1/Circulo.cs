using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Circulo : Figura
    {
        private float r;

        public Circulo(float r)
        {
            this.r = r;
        }
        public override float ReturnArea()
        {
            return r * r * 3.14f;
        }
    }
}
