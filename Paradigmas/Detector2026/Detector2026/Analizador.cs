using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detector2026
{
    /*
    * Nombre del programa: Detector2026
    * Clase: Analizador
    * Autores: Nikol Andrea Mosquera; Sofía Espinoza Bedoya
    * Fecha de elaboración: 11/02/2026
    * 
    * Descripción:
    * Esta clase se encarga de analizar el contenido de un archivo
    * representado en bytes para detectar secuencias específicas
    * asociadas a diferentes virus definidos en el sistema.
    * Utiliza un proceso similar a una máquina de estados para
    * verificar si las secuencias coinciden y contabiliza las
    * veces que cada virus es encontrado.
    */
    internal class Analizador
    {
        /*
        * Atributos (datos miembro):
        * 
        * listaVirus:
        * Arreglo que contiene los objetos Virus definidos
        * para comparar contra el archivo analizado.
        * 
        * contenidoArchivo:
        * Arreglo de bytes que representa el contenido
        * del archivo que será analizado.
        * 
        * contadorUsama, contadorAntrax, contadorEBola,
        * contadorAh1n1, contadorCovid:
        * Variables enteras que almacenan la cantidad de
        * veces que se detecta cada virus.
        */
        private Virus[] listaVirus = new Virus[5];
        private byte[] contenidoArchivo;
        private int contadorUsama = 0;
        private int contadorAntrax = 0;
        private int contadorEBola = 0;
        private int contadorAh1n1 = 0;
        private int contadorCovid = 0;
        /*
      * Constructor de la clase Analizador.
      * 
      * Qué hace:
      * Recibe el contenido del archivo en bytes, lo almacena
      * en el atributo correspondiente y crea la lista de virus
      * que serán utilizados para el análisis.
      * 
      * Parámetros:
      * contenidoBytes -> Arreglo de bytes que representa
      *                   el contenido del archivo a analizar.
      */

        public Analizador(byte[] contenidoBytes) {

            contenidoArchivo = contenidoBytes;
            crearListaVirus();
            /*
         * Método crearListaVirus
         * 
         * Qué hace:
         * Inicializa los objetos Virus con sus nombres y
         * secuencias características, y los almacena dentro
         * del arreglo listaVirus.
         * 
         * Retorna:
         * No retorna ningún valor (void).
         */
        }
        private void crearListaVirus()
        {
            Virus usama = new Virus("USAMA", new byte[] { 15, 30, 15, 49 });
            Virus antrax = new Virus("AMTRAX", new byte[] { 15, 30, 15, 49 });
            Virus eBola = new Virus("eBOLA", new byte[] { 15, 30, 15, 49 });
            Virus ah1n1 = new Virus("AH1N1", new byte[] { 15, 30, 15, 49 });
            Virus covid = new Virus("Covid 19", new byte[] { 15, 30, 15, 49 });

            listaVirus[0] = usama;
            listaVirus[1] = antrax;
            listaVirus[2] = eBola;
            listaVirus[3] = ah1n1;
            listaVirus[4] = covid;
        }
        /*
        * Método analizar
        * 
        * Qué hace:
        * Recorre el contenido del archivo byte por byte y
        * compara las secuencias con las definidas en la lista
        * de virus. Utiliza estados (q0, q1, q2, q3, q4) para
        * simular una máquina de estados durante la detección.
        * Incrementa el contador correspondiente cuando encuentra
        * una coincidencia completa.
        * 
        * Retorna:
        * string -> Estado final alcanzado durante el análisis.
        */
        public string analizar(){

            string estado = "q0";
            for (int i = 0; i < contenidoArchivo.Length; i++){
                if (contenidoArchivo[i] == listaVirus[0].getSecuenciaVirus()[0]) {
                    //q1
                    estado = "q1";
                    if (contenidoArchivo[i + 1] == listaVirus[0].getSecuenciaVirus()[1]) {
                        //q2
                        estado = "q2";
                        if (contenidoArchivo[i + 2] == listaVirus[0].getSecuenciaVirus()[2]) {
                            //q3
                            estado = "q3";
                            if (contenidoArchivo[i + 3] == listaVirus[0].getSecuenciaVirus()[3]){
                                
                                Console.WriteLine("USAMA encontrado");
                                contadorUsama++;
                                estado = "q4";

                            }
                    }
                }
                }
                if (contenidoArchivo[i] == listaVirus[1].getSecuenciaVirus()[0])
                {
                    //q1
                    estado = "q1";
                    if (contenidoArchivo[i + 1] == listaVirus[1].getSecuenciaVirus()[1])
                    {
                        //q2
                        estado = "q2";
                        if (contenidoArchivo[i + 2] == listaVirus[1].getSecuenciaVirus()[2])
                        {
                            //q3
                            estado = "q3";
                            if (contenidoArchivo[i + 3] == listaVirus[1].getSecuenciaVirus()[3])
                            {

                                Console.WriteLine("ANTRAX encontrado");
                                contadorAntrax++;
                                estado = "q4";

                            }
                        }
                    }
                }
                    if (contenidoArchivo[i] == listaVirus[2].getSecuenciaVirus()[0])
                    {
                        //q1
                        estado = "q1";
                        if (contenidoArchivo[i + 1] == listaVirus[2].getSecuenciaVirus()[1])
                        {
                            //q2
                            estado = "q2";
                            if (contenidoArchivo[i + 2] == listaVirus[2].getSecuenciaVirus()[2])
                            {
                                //q3
                                estado = "q3";
                                if (contenidoArchivo[i + 3] == listaVirus[2].getSecuenciaVirus()[3])
                                {
    
                                    Console.WriteLine("EBOLA encontrado");
                                    contadorEBola++;
                                    estado = "q4";
    
                                }
                            }
                        }
                    }
                    if (contenidoArchivo[i] == listaVirus[3].getSecuenciaVirus()[0])
                    {
                        //q1
                        estado = "q1";
                        if (contenidoArchivo[i + 1] == listaVirus[3].getSecuenciaVirus()[1])
                        {
                            //q2
                            estado = "q2";
                            if (contenidoArchivo[i + 2] == listaVirus[3].getSecuenciaVirus()[2])
                            {
                                //q3
                                estado = "q3";
                                if (contenidoArchivo[i + 3] == listaVirus[3].getSecuenciaVirus()[3])
                                {
    
                                    Console.WriteLine("AH1N1 encontrado");
                                    contadorAh1n1++;
                                    estado = "q4";
    
                                }
                            }
                        }
                    }
                if (contenidoArchivo[i] == listaVirus[4].getSecuenciaVirus()[0])
                {
                    //q1
                    estado = "q1";
                    if (contenidoArchivo[i + 1] == listaVirus[4].getSecuenciaVirus()[1])
                    {
                        //q2
                        estado = "q2";
                        if (contenidoArchivo[i + 2] == listaVirus[4].getSecuenciaVirus()[2])
                        {
                            //q3
                            estado = "q3";
                            if (contenidoArchivo[i + 3] == listaVirus[4].getSecuenciaVirus()[3])
                            {

                                Console.WriteLine("COVID encontrado");
                                contadorCovid++;
                                estado = "q4";

                            }
                        }
                    }
                }

            }
            return estado;
        }
        /*
        * Métodos getContador:
        * 
        * Qué hacen:
        * Devuelven la cantidad de veces que cada virus fue
        * encontrado durante el análisis.
        * 
        * Retornan:
        * int -> Número de detecciones del virus correspondiente.
        */


        public int getContadorUsama() {
            return contadorUsama;
        }
         public int getContadorAntrax()
        {
            return contadorAntrax;
        }
         public int getContadorEBola()
        {
            return contadorEBola;
        }
         public int getContadorAh1n1()
        {
            return contadorAh1n1;
        }
         public int getContadorCovid()
        {
            return contadorCovid;
         }
    }
}
