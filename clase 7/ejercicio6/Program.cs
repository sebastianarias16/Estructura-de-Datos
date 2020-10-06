using System;
using System.Collections;

namespace ejercicio6
{
    class Program
    {
        /*Escriba una rutina que reciba una Cola C de números flotantes y devuelva una Pila,
        manteniendo el orden de salida de los elementos. Es de destacar que la Cola C no debe
        sufrir ningún tipo de cambio o alteración.*/
        static void Main(string[] args)
        {
            Queue cola = new Queue();
            Stack pila = new Stack();


            cola.Enqueue(9.5f);
            cola.Enqueue(6.265f);
            cola.Enqueue(95.36f);
            cola.Enqueue(8.26f);

            while (cola.Count > 0)
                pila.Push((float)cola.Dequeue());
           

            while (pila.Count > 0)
                Console.WriteLine("Dato de la cola en la pila: " + (float)pila.Pop());


        }
    }
}
