using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonajeNmspc;

namespace AppInfoStarWars
{
    public partial class frmNaves : Form
    {
        /*instancio objeto del tipo nave*/
        Nave nave;

        /*instancio clase para usar sus metodos*/
        LlenarCombos llc = new LlenarCombos();

        public frmNaves()
        {
            InitializeComponent();

            /*lleno el cbo*/
            llenarComboNaves();
        }

        /*Metodo que llena el cbo con las naves*/
        private void llenarComboNaves() {

            /*itero en el array que me devuelve desdde el archivo Json*/
            foreach (Nave nav in llc.getNaves())
            {
                /*agrego el nombre de cada nave al combo*/
                cboNave.Items.Add(nav.name);
            }


        }

        /*metodo para buscar una determinada nave*/
        private void getNaveBuscada(String naveBuscada) {

            /*itero por las naves devueltas desde el json*/
            foreach (Nave n in llc.getNaves())
            {
                /*verifico que la nave que recorro tiene el mismo nombre que se recibio por parametro*/
                if (naveBuscada==n.name)
                {
                    /*guardo la nave que estoy recorriendo en la variable*/
                    nave = n;
                    
                    /*finalizo la iteracion de las naves*/
                    break;

                }

            }

        }

        /*metodo para listar peliculas en que la nave aparecio*/
        private void llenarListadoPeliculas()
        {
            /*itero por cada elemnto dentro del array de films de la nave encontrada*/
            foreach (String item in nave.films)
            {
                /*itero por el array de peliculas obtenido dese el JSON*/
                foreach (Pelicula pelicula in llc.getPeliculas())
                {
                    /*verifico que la url del array de film de la nave encontrada concuerde con el de la pelicula recorrida*/
                    if (item == pelicula.url)
                    {
                        /*Agrego el nombre de la pelicula recorrida a la list*/
                        lstPeliculas.Items.Add(pelicula.title);

                        /*Termino iteracion*/
                        break;
                    }

                }
            }
          
           
            


        }

        /*Metodo para llenar list de personajes que han piloteado esta nave*/
        private void llenarListadoPilotos() {

            /*itero sobre el array de pilotos de la nave encontrada*/
            foreach (String item in nave.pilots)
            {
                /*itero dentro del array de personajes devuelto desde el json*/
                foreach (Personaje personaje in LlenarCombos.getPersonajes())
                {
                    /*Verifico que el nombre del personaje recorrido concuerde con el item de los pilotos de la nave*/
                    if (personaje.url == item)
                    {
                        /*agrego en el listado de pilotos el nombre del piloto recorrido*/
                        lstPilotos.Items.Add(personaje.name);

                        /*finalizo iteracion*/
                        break;
                    }

                }
                

            }

        }

        private void CboNave_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Limpio listas*/
            Listas.LimpiarListas(lstPeliculas);
            Listas.LimpiarListas(lstPilotos);

            /*Obtengo valor de cbo*/
            String naveSeleccionada = cboNave.SelectedItem.ToString();

            /*buscar nave seleccionada*/
            getNaveBuscada(naveSeleccionada);
            
            /*lleno lista peliculas donde aparece esta nave*/
            llenarListadoPeliculas();

            /*Lista de personajes que han pilotado esta nave*/
            llenarListadoPilotos();

            /*lleno los lbls con la infromacion de la nave encontrada*/
            lblNombre.Text = nave.name;
            lblCapCarga.Text = nave.cargo_capacity;
            lblClase.Text = nave.starship_class;
            lblFabricante.Text = nave.manufacturer;
            lblHiperVelocidad.Text = nave.hyperdrive_rating;
            lblLargo.Text = nave.length;
            lblmglt.Text = nave.MGLT;
            lblModelo.Text = nave.model;
            lblPasajeros.Text = nave.passengers;
            lblPrecio.Text = nave.cost_in_credits;
            lblTiempoFabr.Text = nave.consumables;
            lblTripulacion.Text = nave.crew;
            lblVelMaxAtm.Text = nave.max_atmosphering_speed;

            /*pongo visible el panel*/
            pnlDatos.Visible = true;

        }
    }
}
