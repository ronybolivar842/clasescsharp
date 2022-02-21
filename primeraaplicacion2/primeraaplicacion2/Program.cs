using System;

namespace primeraaplicacion2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

             edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona1);*/



            //var edadPersona = 27;

            //Console.WriteLine(edadPersona);



            double temperatura = 34.5;

            int temperaturaMadrid;

            //conversion explicita
            // casting

            temperaturaMadrid = (int)temperatura;

            //conversion implicita

            int habitantesCiudad = 1000000;

            long habitantesCiudad2018 = habitantesCiudad;


            float pesoMaterial = 5.78F;

            double pesoMaterialPrec = pesoMaterial;


            Console.WriteLine(pesoMaterialPrec);





        }
    }
}
