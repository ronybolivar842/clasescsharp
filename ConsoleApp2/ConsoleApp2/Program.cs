using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            int numAlum, i;

            i = Console.Read();
            double suma = 0, media;

            //Lectura del número de alumnos. Debe ser un valor positivo
            do
            {
                Console.WriteLine("Número de alumnos de la clase: ");
                numAlum = Console.Read();
            } while (numAlum <= 0);

            //se crea un array llamado notas de numAlumn elementos de tipo double
            double[] notas = new double[numAlum];

            // Entrada de datos. Se lee la nota de cada alummo y se guarda
            // en cada elemento del array
            for (i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Alumno " + (i + 1) + " Nota final: ");
                notas[i] = Console.Read();
            }

            // Sumar todas las notas
            for (i = 0; i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }

            // Calcular la media
            
            media = suma / notas.Length;
            // Mostrar la media
            Console.WriteLine("Nota media del curso: %.2f %n", media);

            // Mostrar los valores superiores a la media
            Console.WriteLine("Listado de notas superiores a la media: ");
            for (i = 0; i < notas.Length; i++)
                
            {
                if (notas[i] > media)
                {
                    Console.WriteLine("Alumno numero " + (i + 1) + " Nota final: " + notas[i]);

                }
            }
        }       
    } 
} 
