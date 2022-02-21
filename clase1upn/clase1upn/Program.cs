using System;

namespace clase1upn
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Hola mundo");

            a = 4;
            //a =a+1;

            //a + =1;

            a++;

            //a = a + 5;

            a += 5;

            Console.WriteLine(a);

            //como ingresar datos en la consola

            Console.WriteLine("deseas pasar el curso con 20");

            string respuesta = Console.ReadLine();

            //Console.WriteLine(respuesta);

            //ESTRUCTURA SIMPLE

            if (respuesta == "si")
            {
                Console.WriteLine("ESTUDIA!!, ELABORA TU PC E INTERVIENE INTELIGENTEMENTE EN CLASE ");
            }

            //ESTRUCTURA SELECTIVA DOBLE

            Console.WriteLine("DESEAS GANARTE LA LOTERIA");

            respuesta = Console.ReadLine();

            if (respuesta == "si")
            {
                Console.WriteLine("COMPRAR TINKA");
            }
            
            {
                Console.WriteLine("JUEGA PELOTA CON TU AMIGO");
            }

            
            





        }
    }
}
