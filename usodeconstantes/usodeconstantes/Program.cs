using System;

namespace usodeconstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int VALOR = 5;

            //const int VALOR2 = 7;

            //Console.WriteLine("El valor de la constante es: {1}", VALOR, VALOR2);


            const double PI = 3.1416;

            Console.WriteLine("introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            //double area = radio * radio * PI;

            double area = Math.Pow(radio, 2)*PI;

            Console.WriteLine($"El area del circulo es: {area}");



        }
    }
}
