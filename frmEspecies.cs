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
    public partial class frmEspecies : Form
    {
        /*instancio clase para usar sus metodos*/
        LlenarCombos llc = new LlenarCombos();

        /*Creo variable que gusrdara la especie encontrada*/
        Especies especie;

        public frmEspecies()
        {
            InitializeComponent();

            /*Lleno el combo con las especies*/
            llenarCombo();
         
        }

        private void llenarCombo() {

            
            /*recorro el array de especies obtenidos desde json Local*/
            foreach (Especies especies in llc.getEspecies())
            {
                /*Agrego al combo el nombre de cada especie recorrida*/
                comboBox1.Items.Add(especies.name);
            }

        }

        /*Metodo para buscar una especie por su nombre*/
        private void getBuscarEspecie(String especieSolicitada) {

            /*recorro array de especies devuelto desde json*/
            foreach (Especies especies in llc.getEspecies())
            {
                /*verifico si el nombre de la especie recorrida es igual al de la solicitada*/
                if (especieSolicitada==especies.name)
                {
                    /*creo objeto de la especie y le asigno los datos de la especie encontrada*/
                    especie = especies;

                    /*termino de iterar por las especies*/
                    break;
                }
            }           
        }

        /*Metodo que busca los personajes de esta especie*/
        private void BuscarPersonajes() {

            /*recorro el array de personajes de la especie encontrada*/

            foreach (String item in especie.people)
            {
                /*recorro el array de personajes desde el json*/
                foreach (Personaje personaje in LlenarCombos.getPersonajes())
                {
                    /*verifico que la url del array de especie sea igual al del personaje recorrido*/
                    if (item == personaje.url)
                    {
                        /*agrego el nombre del personaje al listado*/
                        lstPersonajes.Items.Add(personaje.name);

                        /*Termino iteracion*/ 
                        break;
                    }
                }
                
            }
           

        }

        /*Metodo para buscar la pelicula en la que la especie aparece*/
        private void buscarPeliculas() {

            /*recorro los films de la especie*/
            foreach (String item in especie.films)
            {
                /*recorro las peliculas desde el Json*/
                foreach (Pelicula pelicula in llc.getPeliculas())
                {
                    /*verifico si las url son las mismas*/
                    if (item == pelicula.url)
                    {
                        /*agrego el titulo de la pelicula encontrada a la lista*/
                        lstPeliculas.Items.Add(pelicula.title);
                        
                        /*finalizo iteracion*/
                        break;
                    }

                }
              
            }

           
         }

        /*Metodo para obtener el mundo de la especie*/
        private void obtenerMundo() {

            /*Recorro array de mundos desde el  JSON*/
            foreach (Mundo mundo in llc.getMundos())
            {
                /*verifico que las url sean iguales*/
                if (especie.homeworld==mundo.url)
                {
                    /*asigno al lbl el nombre del mundo*/
                    lblMundo.Text = mundo.name;

                    /*Finalizo iteracion*/
                    break;
                }
            }

        }
        
        private void FrmEspecies_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Limpio listas*/
            Listas.LimpiarListas(lstPeliculas);
            Listas.LimpiarListas(lstPersonajes);

            /*Guardo en variable el item seleccionado a bscar*/
            String especieSeleccionada = comboBox1.SelectedItem.ToString();           

            /*Busco los datos de la especie seleccionada*/
            getBuscarEspecie(especieSeleccionada);

            /*Busco personajes de esta especie*/
            BuscarPersonajes();

            /*Busco peliculas donde esta especie haya aparecido*/
            buscarPeliculas();

            /*Obtengo el mundo de esta especie*/
            obtenerMundo();

            /*Completo datos de la especie en los lbls*/
            lblAltura.Text = especie.average_height;
            lblClas.Text = especie.classification;
            lblDesign.Text = especie.designation;
            lblLengua.Text = especie.language;
            lblNombreEspecie.Text = especie.name;
            lblOjos.Text = especie.eye_colors;
            lblPelo.Text = especie.hair_colors;
            lblPiel.Text = especie.skin_colors;
            lblTiempoVida.Text = especie.average_lifespan;

            /*Hago visible el panel con los datos completos*/
            pnl.Visible = true;

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
