using System;
using System.Collections.Generic;
using System.Collections;

namespace ejercicio2
{
    class Program
    {

        /*.Escriba una rutina que reciba una Cola C de números enteros y mueva sus elementos
        a una nueva Pila, pero manteniendo el orden de salida de los elementos. Al finalizar
        la Cola C no debe contener elementos..*/


        public static void Main()
        {

            Queue<int> miCola = new Queue<int>();

            miCola.Enqueue(1);
            miCola.Enqueue(2);
            miCola.Enqueue(3);
            miCola.Enqueue(4);
            miCola.Enqueue(5);
            miCola.Enqueue(6);

            for (byte i = 0; i < 3; i++)
            {

                Console.WriteLine();
            }
        }

 }  }
