using System;
using System.Collections;
using System.Collections.Generic;


namespace ejercicio4
{

    /*Escriba una rutina que reciba dos Pilas P1 y P2 denúmeros flotantes y apile las mismas  en  una nueva Pila resultante. Es de destacar que las Pilas recibidas 
     * no deben sufrir ningún tipo de cambio o alteración*/


    class Program
    {
        public static void concatenarPilas(Stack P1, Stack P2, Stack pax, Stack P3)
        {
            try
            {
                while (P1.Count > 0)
                    pax.Push((float)P1.Pop());
                while (P2.Count > 0)
                    pax.Push((float)P2.Pop());
                while (pax.Count > 0)
                    P3.Push((float)pax.Pop());
                while (P3.Count > 0)
                    Console.WriteLine("Numero: " + P3.Pop());
                    
            }catch(InvalidOperationException e) { Console.WriteLine("" + e.Message); }
        }



        public static void Main()
        {
            Stack pila1 = new Stack();
            Stack pila2 = new Stack();
            Stack pilaaxu = new Stack();
            Stack pila3 = new Stack();


            pila1.Push(1.9f);
            pila1.Push(2.6f);
            pila1.Push(3.956f);
            pila1.Push(4.326f);


            pila2.Push(10.999f);
            pila2.Push(11.3549f);
            pila2.Push(12.35592f);
            pila2.Push(13.12f);
            concatenarPilas(pila1, pila2, pilaaxu, pila3);
            Console.WriteLine("pilas concatendas");

        }
    }
}
