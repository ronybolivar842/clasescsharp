using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int fac = 1, n;
            string linea;
            Console.Write("ingrese un numero entero: ");
            linea = Console.ReadLine();

            n = int.Parse(linea);
            for(int i=1; i<=n; i++)
            {
                fac = fac * i;
            }

            Console.Write("la factorial es: "+fac);
            Console.ReadKey();

        }
    }
}
