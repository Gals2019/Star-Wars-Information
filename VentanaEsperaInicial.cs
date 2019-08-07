using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PersonajeNmspc;

namespace AppInfoStarWars
{
    public partial class VentanaEsperaInicial : Form
    {

        private TaskScheduler _scheduler;

        Thread hilo;

        /*Lista que tendra los nombres de los archivos json a crear en el disco*/
        List<String> Archivos = new List<string>();
       
        public VentanaEsperaInicial()
        {
            _scheduler = TaskScheduler.FromCurrentSynchronizationContext();

            InitializeComponent();  

        }

        private void VentanaEsperaInicial_Load(object sender, EventArgs e)
        {
            /*Cuando carga la pantalla iniciara el metodo de Tareas*/
            hilo = new Thread(Tareas);
            /*El hilo esperara 500 ms antes de ejecutarse para que espere la carga de la ventana y la imagen*/
            Thread.Sleep(500);
            hilo.Start();
        }

        private void Tareas() {

            

            new Task(() =>
            {
                /*Creo un array de tareas, para que se realicen 1 a 1 y vaya mostrando 
                 el avance de la carga de la app en el progressbar*/
                Task[] tareas =
                {
                    /*Por cada tarea envío el valor del progressbar y una leyenda*/
                    Task.Factory.StartNew(()=>TareaArrayDeArchivos(25, "Revisando equilibrio de las Fuerzas."), CancellationToken.None,TaskCreationOptions.LongRunning, _scheduler),
                    Task.Delay(1500),
                    Task.Factory.StartNew(()=>TareaCrearArchivos(50, "Cargando Lanzaderas."), CancellationToken.None,TaskCreationOptions.LongRunning, _scheduler),
                    Task.Delay(1500),
                    Task.Factory.StartNew(()=>TareaActivarBoton(100, "Bienvenido."), CancellationToken.None,TaskCreationOptions.LongRunning, _scheduler)

                };

                Task.WaitAll();

            }).Start();

        }
        /*Metodo que agrega al array de archivos los archivos que seran creados*/
        private void TareaArrayDeArchivos(int valorPGRBR, String informeProgreso) {

            /*Pintando el progressbar*/
            LlenarProgressBar(valorPGRBR);

            /*Genero un hilo que llenara el array de Nombre de Archivos*/
            hilo = new Thread(()=> {

                Archivos.Add("Personajes.json");
                Archivos.Add("Peliculas.json");
                Archivos.Add("Naves.json");
                Archivos.Add("Vehiculos.json");
                Archivos.Add("Especies.json");
                Archivos.Add("Mundos.json");

            });

            Thread.Sleep(1500);
            hilo.Start();
            hilo.Join();
            
            LlenarProgressBar(35);
           

        }

        private void TareaCrearArchivos(int valorPGRBR, String informeProgreso) {


            LlenarProgressBar(valorPGRBR);
            /*Genero otro hilo que llama a la funcion crear archivos desde la clase Config*/
            hilo = new Thread(()=> {

              
                /*Paso el array de archivos al metodo crear archivos*/
                Config.CrearArchivo(Archivos);

            });
            Thread.Sleep(500);
            hilo.Start();
            hilo.Join();
            /*una vez realizada esta tarea pinta el progressbar con un 65% de avance*/
            LlenarProgressBar(65);

        }

        /*Tarea que hara desaparecer el progressbar y aparecera el boton para comenzar la App*/
        private void TareaActivarBoton(int valorPGRBR, String informeProgreso) {
                         
            
            LlenarProgressBar(valorPGRBR);

            btnIniciar.Visible = true;
            prgrBar.Visible = false;

            

        }

        /*funcion para llenar el progressbar con el valor que le llega*/
        private void LlenarProgressBar(int valorprgr)
        {
            prgrBar.Value = valorprgr;
        }
        
        /*Metodo click del btn Start*/
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            /*Instancio ventana pcpal*/
            Principal pcpal = new Principal();
            /*La muestro*/
            pcpal.Show();
            /*oculto esta ventana inicial de carga*/
            this.Hide();
        }

    }
}
