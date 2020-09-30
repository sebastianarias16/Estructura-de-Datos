using System;
using System.Collections;
using System.Collections.Generic;

namespace ejercicio10
{
    /*Escriba una rutina que reciba una Pila P de números flotantes y devuelva una Cola,
     manteniendo el orden de salida de los elementos. Es de destacar que la Pila P no debe
     sufrir ningún tipo de cambio o alteración.*/

    class Program
    {
        static void Main(string[] args)
        {



            Stack pila1 = new Stack();
            Stack pila2 = new Stack();
            Stack pilaaxu = new Stack();
            Stack pila3 = new Stack();


            pila1.Push(1);
            pila1.Push(2);
            pila1.Push(3);
            pila1.Push(4);

            concatenarPilas(pila1);
            Console.WriteLine("pilas concatendas");

            {
                string palabra;

                Queue miCola = new Queue();
                miCola.Enqueue(1);
                miCola.Enqueue(2);
                miCola.Enqueue(3);

                for (byte i = 0; i < 3; i++)
                {
                    palabra = (string)miCola.Dequeue();
                    Console.WriteLine(palabra);
                }
            }
    }   }
}
