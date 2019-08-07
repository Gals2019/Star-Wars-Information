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

        LlenarCombos llc = new LlenarCombos();

        Mundo mundo;
        public frmMundos()
        {
            InitializeComponent();
            llenarCombo();
        }

        private void llenarCombo() {
            foreach (Mundo mundo in llc.getMundos())
            {
                cboMundos.Items.Add(mundo.name);
            }
        }

        private void getMundoBuscado(String nombreMundo) {

            foreach (Mundo m in llc.getMundos())
            {
                if (nombreMundo==m.name)
                {
                    mundo = m;
                    break;
                }
            }

        }

        private void listarPeliculas() {

            
            
            List<Pelicula> listaPeliculas = llc.getPeliculas();

            foreach (var item in mundo.films)
            {
                foreach (Pelicula pelicula in listaPeliculas)
                {
                    if (pelicula.url== item)
                    {
                        lstPeliculas.Items.Add(pelicula.title);
                        break;
                    }
                }
            }

            

        }

        private void listarHabitantes()
        {
           
            List <Personaje> ListadoPersonajes= LlenarCombos.getPersonajes();

            foreach (String item in mundo.residents)
            {
                foreach (Personaje personaje in ListadoPersonajes)
                {
                    if (personaje.url==item)
                    {
                        lstHabitantes.Items.Add(personaje.name);
                        break;
                    }
                }
            }

        }
       

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listas.LimpiarListas(lstHabitantes);
            Listas.LimpiarListas(lstPeliculas);

            String mundoSeleccionado = cboMundos.SelectedItem.ToString();

            getMundoBuscado(mundoSeleccionado);
            listarHabitantes();
            listarPeliculas();

            lblClima.Text = mundo.climate;
            lblDiametro.Text = mundo.diameter+" Km";
            lblGravedad.Text = mundo.gravity;
            lblNombre.Text = mundo.name;
            lblOrbita.Text = mundo.orbital_period+" Años";
            lblPoblacion.Text = mundo.population + " Habitantes";
            lblRota.Text = mundo.rotation_period+" Días";
            lblSupAgua.Text = mundo.surface_water;
            lblTerreno.Text = mundo.terrain;
            

            pnlInfo.Visible = true;
            //this.Size = new Size(816, 542);
        }

    }
}
