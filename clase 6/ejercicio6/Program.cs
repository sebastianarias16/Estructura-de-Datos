using System;
using System.Collections.Generic;

namespace ejercicio6
{
    class Program
    {
        /*Escriba una rutina que reciba una Pila P de números enteros y mueva sus elementos
        a una nueva Pila, pero manteniendo el orden de salida de los mismos. Al finalizar la
        Pila P no debe contener elementos*/

        static void Main(string[] args)
        {
            List<int> listanumeros = new List<int>();

            listanumeros.Add(1);
            listanumeros.Add(2);
            listanumeros.Add(3);
            listanumeros.Add(4);
            listanumeros.Add(5);
            listanumeros.Add(6);

            for (int contador = 0; contador < listanumeros.Count; contador++)
            {
                Console.WriteLine(listanumeros[contador]);

            }
            Console.ReadKey();
        }
    }
}
