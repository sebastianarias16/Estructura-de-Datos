using System;
using System.Collections;

namespace ejercicio1
{
    /*Escriba un programa que inserte valores ordenadamente en una lista.La lista/pila/cola debe almacenar números enteros. 
     * El programa debe leer una secuencia de números enteros de la entrada hasta que se ingrese el número cero.*/
    class Program
    {
        static void Main(string[] args)
        {


            ArrayList numeros = new ArrayList();


            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);
            numeros.Add(8);

            imprime(numeros);


            static void imprime(ArrayList arreglo)
            {


                int nu = 0;

                do
                {

                    {
                        foreach (int n in arreglo)



                            Console.Write(" {0},", n);
                        Console.WriteLine("\n—————————————");

                    }
                    Console.WriteLine("digite 0 si desea terminar la secuencia, si no digite otro numero");
                    nu = Convert.ToInt32(Console.ReadLine());


                } while (nu != 0);

                Console.ReadKey();
            }


        }
    }
}
