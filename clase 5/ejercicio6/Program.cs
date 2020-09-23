using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("ahora vamos a realizar matriz de 5 * 6 y vamos a ver cuantos 0 , positivos y negativos hay en la matriz");

            /*ahora definimos la matriz*/

            int[,] mat = new int[5, 6];


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

            int cero = 0;
            int negativo = 0;
            int positivo = 0;

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (mat[f, c] == 0)
                        cero++;
                    else if (mat[f, c] < 0)
                        negativo++;
                    else
                        positivo++;
                }
            }
            Console.WriteLine("la cantidad de cero que hay en la matriz es de: " + cero);
            Console.WriteLine("");
            Console.WriteLine("la cantidad de negativos que hay en la matriz es de: " + negativo);
            Console.WriteLine("");
            Console.WriteLine("la cantidad de positivos que hay en la matriz es de: " + positivo);
            Console.ReadLine();

            Console.WriteLine("gracias por estar con nosotros nos vemos en la proxima :)");
        }
    }
}
