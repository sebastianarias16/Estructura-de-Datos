using System;

namespace EjercicioDeArbol
{

    //creamos la primera clase
    public class Persona
    {
        //inicializamos la variables 
        protected string nombre;
        protected int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        //inicializamos el public para imprimir la variables
        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }
    }

    // esta es la clase para determinar el suekdo de la persona
    public class Empleado : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }

    //clase la cual nos permite determinar las variables y poder imprimir todo
    class Prueba
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Juan";
            persona1.Edad = 25;
            Console.WriteLine("Los datos de la persona son: ");
            persona1.Imprimir();

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Maria";
            empleado1.Edad = 42;
            empleado1.Sueldo = 2524;
            Console.WriteLine("Los datos del empleado son: ");
            empleado1.Imprimir();

            Console.ReadKey();
        }
    }
}
