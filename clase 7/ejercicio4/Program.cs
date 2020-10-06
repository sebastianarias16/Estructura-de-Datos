using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ejercicio4
{
    class Program
    {

        public static void Main()
        {

            /*.Escriba una rutina que reciba dos Colas C1 y C2 de números enteros y proceda a
              intercambiar sus elementos, pero manteniendo el orden de salida de los mismos. Al
              finalizar la rutina, la Cola C1 tendrá los elementos de la Cola C2 y esta a su vez tendrá los
              elementos de la Cola C1*/

            Queue C1 = new Queue();
            Queue C2 = new Queue();
            Queue CA1 = new Queue();
            Queue CA2 = new Queue();



            C1.Enqueue(9);
            C1.Enqueue(6);
            C1.Enqueue(15);
            C1.Enqueue(8);

            C2.Enqueue(16);
            C2.Enqueue(98);
            C2.Enqueue(32);
            C2.Enqueue(35);

            while (C1.Count > 0)
                CA1.Enqueue((int)C1.Dequeue());
            while (C2.Count > 0)
                CA2.Enqueue((int)C2.Dequeue());
            while (CA1.Count > 0)
                C2.Enqueue((int)CA1.Dequeue());
            while (CA2.Count > 0)
                C1.Enqueue((int)CA2.Dequeue());

            while (C1.Count > 0)
                Console.WriteLine("Dato de la cola 2 en la cola 1: " + (int)C1.Dequeue());
            Console.WriteLine("");
            while (C2.Count > 0)
                Console.WriteLine("Dato de la cola 1 en la cola 2: " + (int)C2.Dequeue());
            Console.WriteLine("");
            Console.WriteLine("colas intercambiadas");


        }
    }
}
