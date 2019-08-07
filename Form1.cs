using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;
using PersonajeNmspc;
using System.IO;


using System.Collections.Generic;

namespace AppInfoStarWars
{
    public partial class Form1 : Form
    {

        Personaje p;

        LlenarCombos llc = new LlenarCombos();
     


        

        public Form1()
        {           
            InitializeComponent();
           
            llenarComboPersonajes();
        }

        private void llenarComboPersonajes() {

            foreach (Personaje personaje in LlenarCombos.getPersonajes())
            {
                cboPersonajes.Items.Add(personaje.name);
            }

        }

        private void getBuscarPersonaje(String nombre) {

            p = new Personaje();

            foreach (Personaje personaje in LlenarCombos.getPersonajes())
            {
                if (personaje.name==nombre)
                {
                    p = personaje;
                    break;
                }
            }
        }

        private void listarPeliculas()
        {
            lstPeliculas.Items.Clear();

            foreach (Pelicula pelicula in llc.getPeliculas())
            {
                foreach (String item in p.films)
                {
                    if (item==pelicula.url)
                    {
                        lstPeliculas.Items.Add(pelicula.title);
                        break;
                    }
                }
            }

        }

        private void listarNaves()
        {
            lstNaves.Items.Clear();

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

        private void Mundo() {

            foreach (Mundo mundo in llc.getMundos())
            {
                if (mundo.url==p.homeworld)
                {
                    lblHogar.Text = mundo.name;
                    break;
                }

            }
        }

        private void CboPersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {   
            /*Obtengo el nombre del personaje desde el cbo*/
            String valorSeleccionado = cboPersonajes.SelectedItem.ToString();
          
            getBuscarPersonaje(valorSeleccionado);
            listarPeliculas();
            listarNaves();
            Mundo();
            lblNombre.Text = p.name;          
            lblAltura.Text = p.height + " cm";
            lblAñoNacimiento.Text = p.birth_year;
            lblGenero.Text = p.gender;
            lblOjos.Text = p.eye_color;
            lblPelo.Text = p.hair_color;
            lblPiel.Text = p.skin_color;
            lblPeso.Text = p.mass + " kg";
            tblpnlPersonaje.Visible = true;
        }


        
        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
