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
    public partial class frmMundos : Form
    {
        /*instancio la clase para usar sus metodos*/
        LlenarCombos llc = new LlenarCombos();

        /*instancio una variable vacia para ser llenada por el mundo encontrado*/
        Mundo mundo;

        public frmMundos()
        {
            InitializeComponent();

            /*lleno el combo con los nombre de los planetas*/
            llenarCombo();
        }

        /*Metodo para llenar el cbo*/
        private void llenarCombo() {
            /*itero en array que viene desde el json*/
            foreach (Mundo mundo in llc.getMundos())
            {
                /*lleno el cbo con los nombres de los mundos encontrados*/
                cboMundos.Items.Add(mundo.name);
            }
        }

        /*busco el mundo seleccionado*/
        private void getMundoBuscado(String nombreMundo) {

            /*itero en el array devuelto desde el archivo json*/
            foreach (Mundo m in llc.getMundos())
            {
                /*verifico si el nombre del mundo buscado concuerda con el mundo que recorro*/
                if (nombreMundo==m.name)
                {
                    /*lleno el objeto con el mundo encontrado*/
                    mundo = m;

                    /*termino la iteracion*/
                    break;
                }
            }

        }
        
        /*metodo para listar las peliculas donde aparece este mundo*/
        private void listarPeliculas() {

                      
            /*itero el array dentro del mundo encontrado*/
            foreach (var item in mundo.films)
            {
                /*itero dentro del array devuelto por el json de peliculas*/
                foreach (Pelicula pelicula in llc.getPeliculas())
                {
                    /*verifico si la url concuerda con el del array recorrido del mundo*/
                    if (pelicula.url== item)
                    {
                        /*agrego el nombre del mundo al list*/
                        lstPeliculas.Items.Add(pelicula.title);

                        /*Termino esta iteracion*/
                        break;
                    }
                }
            }

            

        }

        /*Metodo para llenar list de habitantes de este mundo*/
        private void listarHabitantes()
        {
            /*itero dentro del array de residentes del undo encontrado*/            
            foreach (String item in mundo.residents)
            {
                /*itero dentro del array de personajes del Json*/
                foreach (Personaje personaje in LlenarCombos.getPersonajes())
                {
                    /*Verifico si la url del personaje recorrido es igual al array de residentes del mundo*/
                    if (personaje.url==item)
                    {
                        /*agrego al list el nombre del personaje encontrado*/
                        lstHabitantes.Items.Add(personaje.name);

                        /*termino iteracion*/
                        break;
                    }
                }
            }

        }
       

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Limpio listas*/
            Listas.LimpiarListas(lstHabitantes);
            Listas.LimpiarListas(lstPeliculas);

            /*Obtengo el valor del cbo seleccionado*/
            String mundoSeleccionado = cboMundos.SelectedItem.ToString();

            /*Busco el mundo seleccionado*/
            getMundoBuscado(mundoSeleccionado);

            /*listo los habitantes de ese mundo*/
            listarHabitantes();

            /*Listo las peliculas deonde aparece ese mundo*/
            listarPeliculas();

            /*completo los lbls con los datos del mundo seleccionado*/

            lblClima.Text = mundo.climate;
            lblDiametro.Text = mundo.diameter+" Km";
            lblGravedad.Text = mundo.gravity;
            lblNombre.Text = mundo.name;
            lblOrbita.Text = mundo.orbital_period+" Años";
            lblPoblacion.Text = mundo.population + " Habitantes";
            lblRota.Text = mundo.rotation_period+" Días";
            lblSupAgua.Text = mundo.surface_water;
            lblTerreno.Text = mundo.terrain;
            
            /*hago visible el panel*/
            pnlInfo.Visible = true;
            
        }

    }
}
