using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Cuadrado : Figura
    {
        private float a;

        public Cuadrado(float a)
        {
            this.a = a;
        }
        public override float ReturnArea()
        {
            return a * a;
        }
    }
}
