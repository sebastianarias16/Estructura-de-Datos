using System;

namespace ejercicio1
{
    class empleado
    {

        private string nombre;
        private int sueldo;

        //difinicion del metodo constructor
        public empleado()
        {
            Console.Write("Ingrese nombre:");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el sueldo:");
            string linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }
        public void Impuesto()
        {
            if (sueldo > 3000)
            {
                Console.Write(" se deben pagar impuestos ya que sueldoes mayor a 3000 Sueldo:" + sueldo);
            }
            
        }

        static void Main(string[] args)
        {
            empleado empleado1 = new empleado();
            empleado1.Imprimir();
            empleado1.Impuesto();
            Console.ReadKey();
        }
    }
}
