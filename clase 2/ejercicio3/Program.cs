using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int articulo;
            double iva1 = 0.115;
            double descuento = -0.65;
            double iva;

            Console.WriteLine("ingrese valor de la compra: ");
            articulo = int.Parse(Console.ReadLine());

            if (articulo < 500)
            {

                iva = (articulo * iva1);
                Console.WriteLine("el iva a pagar es: " + iva + "Bs.F");

            }

            else if (articulo > 500)
            {

                iva = (articulo * iva1 - descuento);
                Console.WriteLine("el iva a pagar es: " + iva + "Bs.F");

            }
        }
    }
}
