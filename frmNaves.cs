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
        Nave nave;

        LlenarCombos llc = new LlenarCombos();

        public frmNaves()
        {
            InitializeComponent();
            llenarComboNaves();
        }

        private void llenarComboNaves() {

            foreach (Nave nav in llc.getNaves())
            {
                cboNave.Items.Add(nav.name);
            }


        }

        private void getNaveBuscada(String naveBuscada) {

            foreach (Nave n in llc.getNaves())
            {
                if (naveBuscada==n.name)
                {
                    nave = n;
                    break;

                }

            }

        }

        private void llenarListadoPeliculas() {

           

            foreach (Pelicula pelicula in llc.getPeliculas())
            {
                foreach (String item in nave.films)
                {
                    if (item==pelicula.url)
                    {
                        lstPeliculas.Items.Add(pelicula.title);
                        break;
                    }
                }
            }


        }

        private void llenarListadoPilotos() {

            

            foreach ( Personaje personaje in LlenarCombos.getPersonajes())
            {
                foreach (String item in nave.pilots)
                {
                    if (personaje.url==item)
                    {
                        lstPilotos.Items.Add(personaje.name);
                        break;
                    }

                }
            }

        }

        private void CboNave_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Listas.LimpiarListas(lstPeliculas);
            Listas.LimpiarListas(lstPilotos);

            String naveSeleccionada = cboNave.SelectedItem.ToString();
            getNaveBuscada(naveSeleccionada);
            llenarListadoPeliculas();
            llenarListadoPilotos();

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

            pnlDatos.Visible = true;

        }
    }
}
