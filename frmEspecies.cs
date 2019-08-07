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
        LlenarCombos llc = new LlenarCombos();
        Especies especie;

        public frmEspecies()
        {
            InitializeComponent();
            llenarCombo();
         
        }

        private void llenarCombo() {

            LlenarCombos llc = new LlenarCombos();

            foreach (Especies especies in llc.getEspecies())
            {
                comboBox1.Items.Add(especies.name);
            }

        }

        private void getBuscarEspecie(String especieSolicitada) {

            foreach (Especies especies in llc.getEspecies())
            {
                if (especieSolicitada==especies.name)
                {
                    especie = especies;
                    break;
                }
            }           
        }

        private void BuscarPersonajes() {

        
            foreach (Personaje personaje in LlenarCombos.getPersonajes())
            {
                foreach (String item in especie.people)
                {
                    if (item==personaje.url)
                    {
                        lstPersonajes.Items.Add(personaje.name);
                        break;
                    }
                }
            }

        }

        private void buscarPeliculas() {

            foreach (Pelicula pelicula in llc.getPeliculas())
            {
                foreach (String item in especie.films)
                {
                    if (item==pelicula.url)
                    {
                        lstPeliculas.Items.Add(pelicula.title);
                        break;
                    }
                }
            }
         }

        private void obtenerMundo() {

            foreach (Mundo mundo in llc.getMundos())
            {
                if (especie.homeworld==mundo.url)
                {
                    lblMundo.Text = mundo.name;
                    break;
                }
            }

        }
        
        private void FrmEspecies_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listas.LimpiarListas(lstPeliculas);
            Listas.LimpiarListas(lstPersonajes);

            String especieSeleccionada = comboBox1.SelectedItem.ToString();           

            getBuscarEspecie(especieSeleccionada);

            //llc.llenarList(especie, lstPeliculas);

            BuscarPersonajes();
            buscarPeliculas();
            obtenerMundo();

            
            lblAltura.Text = especie.average_height;
            lblClas.Text = especie.classification;
            lblDesign.Text = especie.designation;
            lblLengua.Text = especie.language;
            lblNombreEspecie.Text = especie.name;
            lblOjos.Text = especie.eye_colors;
            lblPelo.Text = especie.hair_colors;
            lblPiel.Text = especie.skin_colors;
            lblTiempoVida.Text = especie.average_lifespan;

            pnl.Visible = true;

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
