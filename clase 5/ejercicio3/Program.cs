using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int SUMP = 0;
            string linea;
            //porfavor digite el numero 5 porfavor//
            Console.Write("ingresa la cantidad de la matriz 5x5:");
            Random rnd = new Random();
            linea = Console.ReadLine();
            N = int.Parse(linea);
            int[,] MAT = new int[N + 1, N + 1];
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = rnd.Next(0, 9);
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            SUMP = 0;
            for (F = 1; F <= N; F++)
            {
                SUMP = SUMP + MAT[F, F];
            }
            C = N;
            for (F = 1; F <= N; F++)
            {
            }
            Console.WriteLine();
            Console.WriteLine("SUMA DIAGONAL PRINCIPAL ES :" + SUMP);
            Console.ReadLine();
        }
    }
}
