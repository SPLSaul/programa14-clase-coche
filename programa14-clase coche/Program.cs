using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa14_clase_coche
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche();
            miCoche.Captura();
            Console.WriteLine(Visualizar());
            Console.WriteLine("Presione cualquier tecla para salir");
            char tx = Console.ReadKey().KeyChar;
        }
    }
    class Coche
    {
        static string color = " ";
        static string modelo = " ";
        static string motorEncendido = " ";
        static int velocidadMaxima = 0;

        public void Captura()
        {
            Console.Write("Ingresa el color de tu coche");
            color = Console.ReadLine();
            Console.Write("Ingresa el modelo de tu coche");
            modelo = Console.ReadLine();
            Console.Write("Ingresa la velocidad maxima que pueda alcanzar tu coche");
            velocidadMaxima = int.Parse(Console.ReadLine());
            Console.Write("Dejaste le motor encendido?");
            motorEncendido = Console.ReadLine();
            motorEncendido.ToLower();

        }

        public static void Visualizar()
        {
            Console.WriteLine($"Tu coche {modelo} de color {color}, alcanza una velocidad maxima de {velocidadMaxima}
          if (motorEncendido == "si")
            {
                Console.WriteLine("El carro esta encendido, date prisa");
            }
            else
            {
                Console.WriteLine("El carro no esta encendido");
            }
        }
    }
}
