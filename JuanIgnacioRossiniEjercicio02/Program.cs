using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanIgnacioRossiniEjercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            int lado1, lado2, lado3;
            string tipoTriangulo;

            Console.WriteLine("ingrese el primer lado");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo lado");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el tercer lado");
            lado3 = Convert.ToInt32(Console.ReadLine());

            if (lado1+lado2>lado3 && lado2+lado3>lado1 && lado1+lado3>lado2)
            {
                if (lado1==lado2 && lado2==lado3 && lado1==lado3)
                {
                    tipoTriangulo = "equilatero";
                    Console.WriteLine($"las medidas ingresadas forman un triangulo:{tipoTriangulo}");
                }

                if (lado1!=lado2 && lado2!=lado3 && lado1!=lado3)
                {
                    tipoTriangulo = "escaleno";
                    Console.WriteLine($"las medidas ingresadas forman un triangulo:{tipoTriangulo}");
                }

                if (lado1==lado2 && lado1!=lado3 || lado2==lado3 && lado2!=lado1 || lado1==lado3 && lado1!=lado2)
                {
                    tipoTriangulo = "isosceles";
                    Console.WriteLine($"las medidas ingresadas forman un triangulo:{tipoTriangulo}");
                }

            }
            else
            {
                Console.WriteLine("las medidas ingresadas no forman un triangulo");
            }
            Console.ReadLine();

        }
    }
}
