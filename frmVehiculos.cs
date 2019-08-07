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
    public partial class frmVehiculos : Form
    {

        LlenarCombos llc = new LlenarCombos();
        Vehiculo ve;
        public frmVehiculos()
        {
            InitializeComponent();
            llenarComboVehiculos();
        }

        private void llenarComboVehiculos() {

            foreach (Vehiculo v in llc.getVehiculos())
            {
                cboVehiculos.Items.Add(v.name);
            }

        }

        private void buscarVehiculo(String vehiculoBuscado) {

            foreach (Vehiculo v in llc.getVehiculos())
            {
                if (v.name==vehiculoBuscado)
                {
                    ve = v;
                    break;
                }

            }

        }

        private void llenarListaPeliculas() {

            lstPeliculas.Items.Clear();

            foreach (Pelicula pelicula in llc.getPeliculas())
            {
                foreach (String item in ve.films)
                {
                    if (item==pelicula.url)
                    {
                        lstPeliculas.Items.Add(pelicula.title);
                        break;
                    }
                }
            }

        }

        private void llenarListaPilotos() {

            lstPilotos.Items.Clear();

            foreach (Personaje personaje in LlenarCombos.getPersonajes())
            {
                foreach (String item in ve.pilots)
                {
                    if (item== personaje.url)
                    {
                        lstPilotos.Items.Add(personaje.name);
                    }
                }
            }


        }

        private void CboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vehiculoSeleccionado = cboVehiculos.SelectedItem.ToString();
            buscarVehiculo(vehiculoSeleccionado);
            llenarListaPeliculas();
            llenarListaPilotos();

            lblNombre.Text = ve.name;
            lblCarga.Text = ve.cargo_capacity;
            lblClase.Text = ve.vehicle_class;
            lblCosto.Text = ve.cost_in_credits;
            lblFabricante.Text = ve.manufacturer;
            lblLargo.Text = ve.length;
            lblModelo.Text = ve.model;
            lblPasajeros.Text = ve.passengers;
            lblTiempoFab.Text = ve.consumables;
            lblTripula.Text = ve.crew;
            lblVelMaxAtm.Text = ve.max_atmosphering_speed;

            panel1.Visible = true;

        }
    }
}
