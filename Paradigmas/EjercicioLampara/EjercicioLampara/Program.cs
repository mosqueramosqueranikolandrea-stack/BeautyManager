using System;

namespace EjercicioLampara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el ID de la lámpara:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el color de la lámpara:");
            string color = Console.ReadLine();

            Lampara miLampara = new Lampara(id, color);

            int opcion = 0;

            while (opcion != 3)
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Presionar interruptor");
                Console.WriteLine("2. Mostrar estado");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        miLampara.PresionarInterruptor();
                        Console.WriteLine("Interruptor presionado.");
                        break;

                    case 2:
                        miLampara.MostrarEstado();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}

