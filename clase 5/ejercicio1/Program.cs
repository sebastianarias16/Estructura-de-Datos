using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numero;
            numero = new int[5, 6];

            for (int fila = 0; fila < 5; fila++)
            {
                for (int col = 0; col < 6; col++)
                {
                    Console.WriteLine(" digite numero: ");
                    numero[fila, col] = Convert.ToInt16(Console.ReadLine());
                }

            }
            Console.Clear();
            for (int fila = 0; fila < 5; fila++)
            {
                for (int col = 0; col < 6; col++)
                {
                    Console.Write(" " + numero[fila, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
