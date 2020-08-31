using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = new int[5];
            int i, mayor = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("digite le valor del numero {0}", (i + 1));
                datos[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (j < 5)
            {
                if (datos[j] > mayor)
                    mayor = datos[j];
                j++;
            }
            Console.WriteLine("el numero mayor de los datos es {0}", mayor);
            Console.ReadKey();
        }
    }
}
