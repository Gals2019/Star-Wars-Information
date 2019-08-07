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
    public partial class frmPeliculas : Form
    {
        Pelicula p;

       

        LlenarCombos llc = new LlenarCombos();

        public frmPeliculas()
        {
            InitializeComponent();

            llenarComboPelicula();

        }

        private void llenarComboPelicula() {

            foreach (Pelicula p in llc.getPeliculas())
            {
                cboPeliculas.Items.Add(p.title);
            }

        }

        private void buscarPelicula(String nombrePelicula) {

            foreach (Pelicula pe in llc.getPeliculas())
            {
                if (nombrePelicula==pe.title)
                {
                    this.p = pe;
                    break;
                }
            }
        }

        private void llenarListPersonaje() {
            

            foreach (Personaje Pers in LlenarCombos.getPersonajes())
            {
                foreach (String item in this.p.characters)
                {
                    if (item==Pers.url)
                    {
                        lstPersonajes.Items.Add(Pers.name);
                        break;
                    }
                }
            }

        }

        private void llenarListPlanetas() {

            foreach (Mundo mundo in llc.getMundos())
            {
                foreach (String item in p.planets)
                {
                    if (item==mundo.url)
                    {
                        lstPlanetas.Items.Add(mundo.name);
                        break;
                    }
                }
            }

        }

        private void llenarListNaves() {

            foreach (Nave nave in llc.getNaves())
            {
                foreach (String item in p.starships)
                {
                    if (item==nave.url)
                    {
                        lstNaves.Items.Add(nave.name);
                        break;
                    }
                }
            }

        }

        private void llenarListVehiculos() {

            foreach (Vehiculo vehiculo in llc.getVehiculos())
            {
                foreach (String item in p.vehicles)
                {
                    if (item==vehiculo.url)
                    {
                        lstVehiculos.Items.Add(vehiculo.name);
                        break;
                    }
                }
            }

        }

        private void llenarListEspecies() {

            foreach (Especies especies in llc.getEspecies())
            {
                foreach (String item in p.species)
                {
                    if (item==especies.url)
                    {
                        lstEspecies.Items.Add(especies.name);
                        break;
                    }
                }
            }

        }      

        private void CboPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Listas.LimpiarListas(lstEspecies);
            Listas.LimpiarListas(lstNaves);
            Listas.LimpiarListas(lstPersonajes);
            Listas.LimpiarListas(lstPlanetas);
            Listas.LimpiarListas(lstVehiculos);

            //limpiarListas(listaListas);


            String FilmSeleccionado = cboPeliculas.SelectedItem.ToString();

            buscarPelicula(FilmSeleccionado);
            llenarListNaves();
            llenarListPersonaje();
            llenarListPlanetas();
            llenarListVehiculos();
            llenarListEspecies();



            lblDirector.Text = p.director;
            lblEpisodio.Text = (p.episode_id).ToString();
            lblFechaEstreno.Text = p.release_date;
            lblProductor.Text = p.producer;
            lblTituloFilm.Text = p.title;
            lblOpening.Text = p.opening_crawl;

            pnlDatos.Visible = true;
        }
    }
}
