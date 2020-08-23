using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int articulo;
            double comison1 = 0.05;
            double comision2 = 0.07;
            double comisionf;

            Console.WriteLine("Ingrese el valor del articulo de la tienda: ");
            articulo = int.Parse(Console.ReadLine());

            if (articulo < 10)
            {

                comisionf = (articulo * comison1);
                Console.WriteLine("a comisión por el producto es de: " + comisionf + "Bs.F. ");

            }

            else if (articulo >= 10)
            {

                comisionf = (articulo * comision2);
                Console.WriteLine("la comisión por el producto es de: " + comisionf + "Bs.F. ");

            }
        }
    }
}
