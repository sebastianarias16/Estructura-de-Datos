using System;
using System.Collections;
using System.Collections.Generic;





namespace ejercicio3
{
    /*Escriba un programa que reciba la dirección del primer nodo de una lista/pila/cola simple de números enteros y devuelva un apuntador al nodo donde exista el número.
     * <x>.Este número es recibido por el método. Se debe retornar NULL si el valor de <x> no se encuentra en la lista/pila/cola.*/
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            numeros.Add(1);
            numeros.Add(365);
            numeros.Add(3);
            numeros.Add(425);
            numeros.Add(1665);
            numeros.Add(2020);
            numeros.Add(7);
            numeros.Add(202);

            imprime(numeros);
            

            int num;

            static void imprime(List<int> arreglo)
            {


                {

                    foreach (int n in arreglo)


                        Console.Write(" {0},", n);
                    Console.WriteLine("\n—————————————");

                }
            }


            Console.WriteLine("digite aver si se encuentra el numero que usted quiere ");
            num = Convert.ToInt32(Console.ReadLine());

            if (numeros.Contains(num))
                Console.WriteLine("numero encontrado: " + num);
            else
                Console.WriteLine("NULL");
        }

        
    }
}
