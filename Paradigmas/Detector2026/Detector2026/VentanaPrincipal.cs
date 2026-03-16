using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detector2026
{
    /*
   * Nombre del programa: Detector2026
   * Clase: VentanaPrincipal
   * Autores: Nikol Andrea Mosquera; Sofía Espinoza Bedoya
   * Fecha de elaboración: 11/02/2026
   * 
   * Descripción:
   * Esta clase representa la ventana principal de la aplicación
   * antivirus. Contiene la definición de los componentes gráficos
   * (botones, etiquetas y cajas de texto) y la configuración
   * inicial de la interfaz de usuario. Desde esta ventana el usuario
   * puede buscar un archivo, visualizar su ruta, analizar su contenido
   * y observar el estado del análisis.
   */
    public partial class VentanaPrincipal : Form
    {
        private byte[] bytes;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //declara un componente para explorar archivos 
            OpenFileDialog explorador;
            //crea el componente 
            explorador = new OpenFileDialog();
            //muestra el componente

            explorador.ShowDialog();

            //obtiene la ruta del archivo seleccionado y la muestra en el textBoxRuta
            textBoxRuta.Text = explorador.FileName;

            Admin_Archivo myAdmin = new Admin_Archivo();

            if (explorador.FileName != "") { 
                

                bytes = myAdmin.leerBytes(explorador.FileName);

                string cadenaBytes = " ";

                for (int i = 0; i < bytes.Length; i++)
                {
                    cadenaBytes += bytes[i] + " ";

                }
                //Enviar el contenido del archivo en bytes 
                textBoxByte.Text = cadenaBytes;

                buttonAnalizar.Enabled = true;

            }
            else
            {
                MessageBox.Show("Debes seleccionar una ruta valida!!");
                    
            }
          //Evento para el botón de búsqueda de archivos. Permite al usuario seleccionar un archivo, muestra su ruta y su contenido en bytes, y habilita el botón de análisis si se selecciona un archivo válido.
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            //Evento vacío (sin funcionalidad) para la carga de la ventana principal
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Evento vacío (sin funcionalidad) para el cambio de texto en textBoxByte

        }

        private void buttonAnalizar_Click(object sender, EventArgs e)
        {
           Analizador myAnalizador = new Analizador(bytes);
            
            myAnalizador.analizar();

            labelValorEstado.Text = myAnalizador.analizar();

            myAnalizador.getContadorUsama();

            MessageBox.Show("USAMA Encontrado: " + myAnalizador.getContadorUsama() + " veces." + "\n"+
                            "Amtrax Encontrado: " + myAnalizador.getContadorAntrax() + " veces." + "\n"+
                            "Amtrax Encontrado: " + myAnalizador.getContadorEBola() + " veces." + "\n"+
                            "Amtrax Encontrado: " + myAnalizador.getContadorCovid() + " veces." + "\n"+
                            "Amtrax Encontrado: " + myAnalizador.getContadorAh1n1() + " veces." + "\n");

        }
        //Eventos vacíos (sin funcionalidad) para los componentes gráficos
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
