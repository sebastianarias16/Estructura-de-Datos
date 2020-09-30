using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ejercicio5
{
    /*Escriba una rutina que recib una Pila P de números enteros y devuelva una copia exacta dela misma.Es de destacar que la Pila P 
     * no debe sufrir ningún tipo de cambio o alteración.*/


    class Program
    {
        public static void DuplicarPilar(Stack P1,  Stack P2, Stack P3)
        {
            try
            {
                while (P1.Count > 0)
                    P2.Push((int)P1.Pop());
                while (P2.Count > 0)
                    P3.Push((int)P2.Pop());
                while (P3.Count > 0)
                    Console.WriteLine("Numero: " + P3.Pop());

            }
            catch (InvalidOperationException e) { Console.WriteLine("" + e.Message); }
        }



        public static void Main()
        {
            Stack pila1 = new Stack();
            Stack pilayu = new Stack();
            Stack pilacop = new Stack();


            pila1.Push(36);
            pila1.Push(24);
            pila1.Push(12);
            pila1.Push(13);

            DuplicarPilar(pila1, pilayu, pilacop);
            Console.Write("copia de la pila");

        }
    }
}
