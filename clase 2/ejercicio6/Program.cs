﻿using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int dist, tiem;
            double costo;

            Console.Write("Ingresar Distancia del Viaje programado: ");
            dist = int.Parse(Console.ReadLine());
            Console.Write("Ingresar Tiempo de Estancia del vieje: ");
            tiem = int.Parse(Console.ReadLine());

            if (dist > 800 && tiem > 7)
            {

                costo = (dist * 2.5) * 0.30;
                Console.WriteLine("El precio del boleto es de: $" + costo);

            }
            else
            {
                costo = dist * 2 * 2.5;
                Console.WriteLine("El Costo del boleto es: $" + costo);
            }
        }
    }
}
