using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detector2026
{
    /*
     * Nombre del programa: Detector2026
     * Clase: Program
     * Autores: Nikol Andrea Mosquera; Sofía Espinoza Bedoya
     * Fecha de elaboración: 11/02/2026
     * 
     * Descripción:
     * Esta clase contiene el punto de entrada principal de la
     * aplicación. Desde aquí se inicializa la configuración
     * básica de Windows Forms y se ejecuta la ventana principal
     * (VentanaPrincipal), que representa la interfaz gráfica
     * del antivirus.
     */
    internal static class Program
    {

        /*
         * Método Main (Punto de entrada del programa)
         * 
         * Qué hace:
         * Es el método principal que se ejecuta al iniciar
         * la aplicación. Configura el estilo visual de la
         * interfaz, establece la compatibilidad del renderizado
         * de texto y lanza la ventana principal del sistema.
         * 
         * Parámetros:
         * Este método no recibe parámetros.
         * 
         * Retorna:
         * No retorna ningún valor (void).
         */
        [STAThread]
        static void Main()
        {
            /*
            * Application.EnableVisualStyles():
            * Activa los estilos visuales modernos del sistema
            * operativo para que la interfaz gráfica tenga
            * una apariencia actual.
            */
            Application.EnableVisualStyles();
            /*
            * Application.SetCompatibleTextRenderingDefault(false):
            * Define el método de renderizado del texto dentro
            * de la aplicación para mejorar compatibilidad y
            * rendimiento.
            */
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            * Application.Run(new VentanaPrincipal()):
            * Inicia la ejecución de la aplicación mostrando
            * la ventana principal (VentanaPrincipal).
            */
            Application.Run(new VentanaPrincipal());
        }
    }
}
