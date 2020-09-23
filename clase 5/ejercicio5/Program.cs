using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ahora vamos a realizar matriz de 6 * 8");

            /*ahora definimos la matriz*/

            int[,] mat = new int[6,8];
           

            /* ahora vamos a llenar la matriz*/

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese el elemento [" + (f + 1) + "  " + (c + 1) + "]: ");
                    ;
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
            /*mostramos la matriz*/
            Console.WriteLine(" ");
            Console.WriteLine("La matriz que queda es la siguente:");
            Console.WriteLine(" ");


            for (int f = 0; f < mat.GetLongLength(0); f++)
            {
                for (int c = 0; c < mat.GetLongLength(1); c++)
                {
                    Console.Write("    " + mat[f, c] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
