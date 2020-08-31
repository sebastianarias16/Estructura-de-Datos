using System;


namespace ejercicio4
{
    class Program
    {

        static void Main(string[] args)
        {

            int NAlum;
            int NNotas;
            int Cont = 0;
            double ContR;
            int cant = 0;

            Console.WriteLine("Digite la cantidad de los estudiantes");
            NAlum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

 
            for (int i = 0; i <= NAlum; i++)
            {

                Console.WriteLine("Digite la cantidad de notas del estudiante");
                NNotas = Convert.ToInt32(Console.ReadLine());

                for (int n = 0; n <= NNotas; n++)
                {
                    Console.WriteLine("Calificacion: ");
                    cant = Convert.ToInt32(Console.ReadLine());
                    Cont = Cont + cant;

                }
                ContR = (Cont / NNotas);
                Console.WriteLine("La media es de: " + ContR);
            }
            
            
        }
    }
}
