using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int par = 0;
            int impar = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("digite el numero entero");
                num = Convert.ToInt32(Console.ReadLine());

                if ((num % 2) == 0)
                    par = par + num;
                else
                    impar = impar + num;
            }

            Console.WriteLine("la suma de los numeros impares es: " + impar);
            Console.WriteLine("la suma de numeros pares es: " + par);
        }
    }
    
}
