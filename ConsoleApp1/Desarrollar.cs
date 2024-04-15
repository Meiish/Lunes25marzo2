using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Desarrollar
    {
        public void Ejecutador()
        {
            Menu();
        }
        private void Menu()
        {
            bool mediador = true;

            while (mediador)
            {
                Figura figura = null;

                Console.WriteLine("Introduce el numero de la figura geometrica que quieres calcular");
                Console.WriteLine("1. Rectangulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Circulo");
                Console.WriteLine("4. Triangulo");
                Console.WriteLine("5. Salir");

                string orden = Console.ReadLine();

                switch (orden)
                {
                    case "1":
                        figura = GetRectangulo();
                        break;
                    case "2":
                        figura = GetCuadrado();
                        break;
                    case "3":
                        figura = GetCirculo();
                        break;
                    case "4":
                        figura = GetTriangulo();
                        break;
                    case "5":
                        mediador = false;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                if (figura != null)
                {
                    Console.WriteLine($"el area es {figura.ReturnArea()}");
                    Console.WriteLine("quieres volver a calcular alguna otra figura?");

                    string orden2 = Console.ReadLine();

                    switch (orden2)
                    {
                        case "6":
                            Console.WriteLine("Si");
                            break;
                        case "7":
                            Console.WriteLine("No");
                            break;
                    }
                }
            }
        }

        private Rectangulo GetRectangulo()
        {
            float b;
            float h;

            Console.WriteLine("escribe el valor de la base del rectangulo");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("escribe el valor de la altura del rectangulo, por favor");

            h = float.Parse(Console.ReadLine());

            Rectangulo rectangulo = new Rectangulo(b, h);

            return rectangulo;
        }
        private Cuadrado GetCuadrado()
        {
            float a;

            Console.WriteLine("escribe el valor del lado del cuadrado");
            a = float.Parse(Console.ReadLine());

            Cuadrado cuadrado = new Cuadrado(a);

            return cuadrado;
        }
        private Circulo GetCirculo()
        {
            float r;

            Console.WriteLine("escribe el valor de la radio del circulo");
            r = float.Parse(Console.ReadLine());

            Circulo circulo = new Circulo(r);

            return circulo;
        }
        private Triangulo GetTriangulo()
        {
            float b;
            float h;

            Console.WriteLine("escribe el valor de la base del triangulo");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("escribe el valor de la altura del triangulo, por favor");

            h = float.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(b, h);

            return triangulo;
        }
    }
}
