using System;
using System.Collections.Generic;
using System.Text;

namespace MiPrimerApp
{
     public class Tanque
    {
        // atributos
        int[] mediciones = new int[10];
        int contador = 0;

        //métodos
        public void RegistrarMedicion(int medicion)
        {
            if (contador == mediciones.Length - 1)
            {

                {
                    mediciones[contador] = medicion;
                    contador++;
                }
                double CalcularPromedio()
                {
                    if (contador < mediciones.Length - 1)
                    {
                        return 0f;
                    }
                    {
                        return mediciones.Sum() / mediciones.Length;
                    }
                }
            }
        }

        internal double CalcularPromedio()
        {
            throw new NotImplementedException();
        }
    }
}

