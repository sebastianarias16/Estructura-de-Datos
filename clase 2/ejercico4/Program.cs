using System;

namespace ejercico4
{
    class Program
    {
        static void Main(string[] args)
        {
            double t1, t2, t3, t4;
            double SalBase;
            double SalNeto, SalNeto2;
            double ReteFuente1 = 0.05;
            double ReteFuente2 = 0.08;

            Console.WriteLine("Digite el salario Base del Empleado: 1");
            SalBase = double.Parse(Console.ReadLine());
            if (SalBase > 1500 || SalBase <= 3000)
            {
                SalNeto = SalBase - (SalBase * ReteFuente1);
                Console.WriteLine("El salario neto del trabajor es de: " + SalNeto);
            }
            else if (SalBase > 3000)
            {
                SalNeto2 = SalBase - (SalBase * ReteFuente2);
                Console.WriteLine("El salario neto de este trabajador es de: " + SalNeto2);
            }
            else
            {

                Console.WriteLine("EL salario neto del trabajador es de: " + SalBase);

            }
            Console.WriteLine("Digite el salario Base del Empleado: 2");
            SalBase = double.Parse(Console.ReadLine());
            if (SalBase > 1500 || SalBase <= 3000)
            {
                SalNeto = SalBase - (SalBase * ReteFuente1);
                Console.WriteLine("El salario neto del trabajor es de: " + SalNeto);
            }
            else if (SalBase > 3000)
            {
                SalNeto2 = SalBase - (SalBase * ReteFuente2);
                Console.WriteLine("El salario neto de este trabajador es de: " + SalNeto2);
            }
            else
            {

                Console.WriteLine("EL salario neto del trabajador es de: " + SalBase);

            }
            Console.WriteLine("Digite el salario Base del Empleado: 3");
            SalBase = double.Parse(Console.ReadLine());
            if (SalBase > 1500 || SalBase <= 3000)
            {
                SalNeto = SalBase - (SalBase * ReteFuente1);
                Console.WriteLine("El salario neto del trabajor es de: " + SalNeto);
            }
            else if (SalBase > 3000)
            {
                SalNeto2 = SalBase - (SalBase * ReteFuente2);
                Console.WriteLine("El salario neto de este trabajador es de: " + SalNeto2);
            }
            else
            {

                Console.WriteLine("EL salario neto del trabajador es de: " + SalBase);

            }
            Console.WriteLine("Digite el salario Base del Empleado: 4");
            SalBase = double.Parse(Console.ReadLine());

            if (SalBase > 1500 || SalBase <= 3000)
            {
                SalNeto = SalBase - (SalBase * ReteFuente1);
                Console.WriteLine("El salario neto del trabajor es de: " + SalNeto);
            }
            else if (SalBase > 3000)
            {
                SalNeto2 = SalBase - (SalBase * ReteFuente2);
                Console.WriteLine("El salario neto de este trabajador es de: " + SalNeto2);
            }
            else
            {

                Console.WriteLine("EL salario neto del trabajador es de: " + SalBase);

            }
        }
    }
}
