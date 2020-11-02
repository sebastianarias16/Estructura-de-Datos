using System;

namespace ejercicio3
{
    class club
    {
        private socio socio1, socio2, socio3;

        public club()
        {
            socio1 = new socio();
            socio2 = new socio();
            socio3 = new socio();
        }

        public void MayorAntiguedad()
        {
            Console.Write("Socio con mayor antiguedad: ");
            if (socio1.RetornarAntiguedad() > socio2.RetornarAntiguedad() &&
                socio1.RetornarAntiguedad() > socio3.RetornarAntiguedad())
            {
                socio1.Imprimir();
            }
            else
            {
                if (socio2.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                {
                    socio2.Imprimir();
                }
                else
                {
                    socio3.Imprimir();
                }
            }

        }

        static void Main(string[] args)
        {
            club club1 = new club();
            club1.MayorAntiguedad();
            Console.ReadKey();
        }
    }

    class socio
    {
        private string nombre;
        private int antiguedad;

        public socio()
        {
            Console.Write("Ingrese nombre:  ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese los años de antiguedad en el club: ");
            antiguedad = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene una antiguedad de " + antiguedad);
        }

        public int RetornarAntiguedad()
        {
            return antiguedad;
        }
    }

}
