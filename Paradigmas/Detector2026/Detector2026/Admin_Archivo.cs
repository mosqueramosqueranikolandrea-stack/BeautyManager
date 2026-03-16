using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detector2026
{
    /// * Nombre del programa: Detector2026
    /// * Clase: Admin_Archivo
    /// * Autores: Nikol Andrea Mosquera; Sofía Espinoza Bedoya
    /// * Fecha de elaboración: 11/02/2026
    /// * Descripción:
    ///* Esta clase se encarga de manejar la lectura de archivos dentro del sistema.
    ///* Su función principal es proporcionar un método para leer el contenido de un archivo
    ///* en forma de bytes, lo que permite que el programa pueda analizar su contenido posteriormente.
    ///* El método leerBytes recibe la ruta del archivo, lee su contenido utilizando la clase File
    ///* y retorna un arreglo de bytes que representa el contenido del archivo, facilitando así su procesamiento en otras partes del programa.
    
    internal class Admin_Archivo
    {
        //* Constructor de la clase Admin_Archivo.
        
        public Admin_Archivo(){
            // No se requiere realizar ninguna acción específica al crear una instancia de esta clase, por lo que el constructor está vacío.

        }
        public byte[] leerBytes(string ruta){
            // Lee el contenido del archivo ubicado en la ruta especificada y lo almacena en un arreglo de bytes.

            byte[] bytes = File.ReadAllBytes(ruta);

            return bytes;
        }
    }
}
