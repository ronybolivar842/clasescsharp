using System;

namespace TRABAJODECAMPO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TIENES MAS DE 18 AÑOS");

            string res = Console.ReadLine();

            if (res == "si")
            {
                Console.WriteLine("puedes tomar una cerveza");
            }

            else Console.WriteLine("REGRESA A TU CASA!!!");


        }
    }
}
