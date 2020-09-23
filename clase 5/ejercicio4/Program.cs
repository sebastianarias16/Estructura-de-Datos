using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int NUMER = 0;
            string linea;
            //porfavor digite el numero 10 porfavor//
            Console.Write("ingresa la cantidad de matriz 10x10:");
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
            // DIAGONAL PRINCIPAL
            NUMER = 0;
            for (F = 1; F <= N; F++)
            {
                NUMER = -0 + MAT[F, F];
            }
            Console.WriteLine();
            Console.WriteLine("EL NUMERO MENOR ES :" + NUMER);
            Console.ReadLine();
        }
    }
}
