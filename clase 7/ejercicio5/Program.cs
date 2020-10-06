using System;
using System.Collections;

namespace ejercicio5
{
    class Program
    {
        /*Escriba una rutina que reciba una Cola C de números flotantes y devuelva una nueva Cola
        pero con los elementos invertidos, es decir el ultimo de la Cola C, pasará a ser el primero
        de la nueva Cola. Es de destacar que la Cola C no debe sufrir ningún tipo de cambio o
        alteración*/

        static void Main(string[] args)
        {


            Queue cola = new Queue();
            Stack ayuda = new Stack();


            cola.Enqueue(9.5f);
            cola.Enqueue(6.265f);
            cola.Enqueue(95.36f);
            cola.Enqueue(8.26f);

            while (cola.Count > 0)
                ayuda.Push((float)cola.Dequeue());
            while (ayuda.Count > 0)
                cola.Enqueue((float)ayuda.Pop());

            while (cola.Count > 0)
                Console.WriteLine("Dato de la cola: " + (float)cola.Dequeue());

            Console.WriteLine("cola invertida");


        }
    }
}
