using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detector2026
{
    /*
      * Nombre del programa: Detector2026
      * Clase: Virus
      * Autores: Nikol Andrea Mosquera; Sofía Espinoza Bedoya
      * Fecha de elaboración: 11/02/2026
      * 
      * Descripción:
      * Esta clase representa un virus dentro del sistema detector. 
      * Su función es almacenar la información básica de un virus,
      * incluyendo su nombre y su secuencia (arreglo de bytes) que
      * puede ser utilizada posteriormente para procesos de análisis
      * o detección dentro del programa.
      */

    internal class Virus
    {
        /*
         * Atributos (datos miembro):
         * 
         * nombreVirus:
         * Guarda el nombre identificador del virus.
         * Es de tipo string y permite reconocer el virus
         * dentro del sistema.
         * 
         * secuenciaVirus:
         * Arreglo de bytes que representa la secuencia
         * característica del virus. Esta secuencia puede
         * ser utilizada para comparar o detectar patrones
         * dentro de otros datos.
         */

        private string nombreVirus;
        private byte[] secuenciaVirus;
        /*
        * Constructor de la clase Virus.
        * 
        * Qué hace:
        * Inicializa un objeto Virus asignando su nombre
        * y su secuencia de bytes.
        * 
        * Parámetros:
        * nombre -> Representa el nombre del virus que se va a crear.
        * secuencia -> Arreglo de bytes que contiene la secuencia
        *              característica del virus.
        */

        public Virus(string nombre, byte[] secuencia)
        {
            nombreVirus = nombre;
            secuenciaVirus = secuencia;
            /*
        * Método: getSecuenciaVirus
        * 
        * Qué hace:
        * Devuelve la secuencia de bytes asociada al virus.
        * 
        * Retorna:
        * byte[] -> Arreglo de bytes que contiene la secuencia
        *           del virus almacenada en el atributo
        *           secuenciaVirus.
        */
        }
        public byte[] getSecuenciaVirus(){
            return secuenciaVirus;
        }
    }
}
