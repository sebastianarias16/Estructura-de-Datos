using System;
using System.Linq;
using System.Text; 
using System.Collections;  
using System.Collections.Generic;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, l;
            Console.Write("ingrese cantidad de k: ");
            k = double.Parse(Console.ReadLine());
            l = 0.453592;
            l = k * l;
            Console.WriteLine("equivale en l {0}", l);
            Console.ReadLine();
        }
    }
}
