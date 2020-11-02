using System;

namespace ejercicio2
{
    class OperacionesCalculo
    {

        int valor1;
        int valor2;
        private OperacionesCalculo()
        {
            Console.Write("digite el valor 1:");
            string linea = Console.ReadLine();
            valor1 = int.Parse(linea);
            Console.Write("digite el valor 2:");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }
        private void Sumar()
        {
            int suma;
            suma = valor1 + valor2;
            Console.WriteLine("el total de la suma es:" + suma);
        }
        private void Restar()
        {
            int resta;
            resta = valor1 - valor2;
            Console.WriteLine("el total de la resta es:" + resta);
        }
        private void Multiplicar()
        {
            int multiplicacion;
            multiplicacion = valor1 * valor2;
            Console.WriteLine("el total de la multiplicacion es:" + multiplicacion);
        }
        private void Dividir()
        {
            int division;
            division = valor1 / valor2;
            Console.WriteLine("el total de la division es:" + division);
        }
        static void Main(string[] args)
        {
            OperacionesCalculo opera = new OperacionesCalculo();
            opera.Sumar();
            opera.Restar();
            opera.Multiplicar();
            opera.Dividir();
            Console.ReadKey();
        }
    }
}
