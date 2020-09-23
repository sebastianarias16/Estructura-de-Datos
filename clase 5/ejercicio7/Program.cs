using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas;
            int columnas;

            Console.WriteLine("Ahora vamos a sumar dos matrizes");

            Console.WriteLine("porfavor digitame la cantidad de filas que va a tener");
            filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("porfavor digitame la cantidad de columnas que va a tener");
            columnas = Convert.ToInt32(Console.ReadLine());

            int[,] M1 = new int[filas, columnas];

            for (int f = 0; f < M1.GetLongLength(0); f++)
            {

                for (int c = 0; c < M1.GetLongLength(1); c++)
                {
                    Console.Write(" digite M1 [" + (f + 1) + "  " + (c + 1) + "]: ");
                    M1[f, c] = int.Parse(Console.ReadLine());


                }

            }

            Console.WriteLine(" ");
            Console.WriteLine("La matriz que queda de M1 es:");
            Console.WriteLine(" ");


            for (int f = 0; f < M1.GetLongLength(0); f++)
            {
                for (int c = 0; c < M1.GetLongLength(1); c++)
                {
                    Console.Write("    " + M1[f, c] + " ");
                }
                Console.WriteLine();
            }



            int[,] M2 = new int[filas, columnas];

            for (int fi = 0; fi < M2.GetLongLength(0); fi++)
            {

                for (int co = 0; co < M2.GetLongLength(1); co++)
                {
                    Console.Write(" digite M2 [" + (fi + 1) + "  " + (co + 1) + "]: ");
                    M2[fi, co] = int.Parse(Console.ReadLine());


                }

            }

            Console.WriteLine(" ");
            Console.WriteLine("La matriz que queda de M2 es:");
            Console.WriteLine(" ");


            for (int fi = 0; fi < M2.GetLongLength(0); fi++)
            {
                for (int co = 0; co < M2.GetLongLength(1); co++)
                {
                    Console.Write("    " + M2[fi, co] + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine(" ");
            Console.WriteLine("La SUMA de M1 y M2 es la siguiente");
            Console.WriteLine(" ");

            float[,] MR = new float[filas, columnas];

            for (int f = 0; f < M1.GetLongLength(0); f++)
            {

                for (int c = 0; c < M1.GetLongLength(1); c++)
                {


                    MR[f, c] = M1[f, c] + M2[f, c];
                    Console.Write("    " + MR[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
