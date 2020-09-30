using System;

namespace ejercicio8
{
    /*Escriba una rutina que reciba una Cola C de números enteros y mueva sus elementos
    a una nueva Pila, pero invirtiendo el orden de salida de los elementos. Al finalizar la Cola
    C no debe contener elementos.*/
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Main1()
        {
            string palabra;

            Queue miCola = new Queue();
            miCola.Enqueue("1");
            miCola.Enqueue("2");
            miCola.Enqueue("3");
            miCola.Enqueue("4");
            miCola.Enqueue("5");
            miCola.Enqueue("6");

            for (byte i = 0; i < 3; i++)
            {
                palabra = (string)miCola.Enqueue();
                Console.WriteLine(palabra);
            }
        }

        private class Queue
        {
            internal void Enqueue(string v)
            {
                throw new NotImplementedException();
            }

            internal string Enqueue()
            {
                throw new NotImplementedException();
            }
        }
    }
}
