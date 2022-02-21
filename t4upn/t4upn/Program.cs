using System;

namespace t4upn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 4, 3, 7, 10, 1, 5, 7 };

            Array.Sort(valores);

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            Console.ReadLine();


        }
    }
}
