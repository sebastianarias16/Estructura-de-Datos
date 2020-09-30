using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio2
{
    /*Escriba un programa que calcule la sumatoria de los cuadra dos de los elementos de una lista/pila/colade números enteros.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("buenas tardes esta es la lista");

            List<int> numeros1 = new List<int>()
            {
                8,2,15,4,9,16,32

            };

            var suma = numeros1.Sum();
            

            imprime(numeros1);

            static void imprime(List<int> arreglo)
            {


                {
                    foreach (int n in arreglo)



                        Console.Write(" {0},", n);
                    Console.WriteLine("\n—————————————");

                }
            }
            Console.WriteLine("la suma de la lista es la siguente");
            Console.WriteLine(suma);
        }
    }
}
