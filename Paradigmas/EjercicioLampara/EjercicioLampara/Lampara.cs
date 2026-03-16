using System;

namespace EjercicioLampara
{
    public class Lampara
    {
        
        private int id;
        private string color;
        private bool estado;   // true = encendida, false = apagada

     
        public Lampara(int id, string color)
        {
            this.id = id;
            this.color = color;
            this.estado = false;   
        }

      

        public void PresionarInterruptor()
        {
            estado = !estado;   
        }

        public void MostrarEstado()
        {
            Console.WriteLine("\n--- INFORMACIÓN DE LA LÁMPARA ---");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Color: " + color);

            if (estado)
                Console.WriteLine("Estado: ENCENDIDA");
            else
                Console.WriteLine("Estado: APAGADA");
        }
    }
}

