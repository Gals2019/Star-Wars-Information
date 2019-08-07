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
        /*Creamos una variable del tipo Personaje*/
        Personaje p;
        /*instanciamos una variable del tipo LlenarCombos para usar sus metodos*/
        LlenarCombos llc = new LlenarCombos();

        public Form1()
        {           
            InitializeComponent();
           /*Lenamos el cbo con los nombres de los personajes*/
            llenarComboPersonajes();
        }

        private void llenarComboPersonajes() {
            /*recorremos el array que viene desde el fichero Personajes.JSON*/
            foreach (Personaje personaje in LlenarCombos.getPersonajes())
            {
                /*agregamos el nombre de cada personaje al combobox*/
                cboPersonajes.Items.Add(personaje.name);
            }

        }

        /*Metodo para buscar un personaje por su nombre*/
        private void getBuscarPersonaje(String nombre) {

            /*Creamos un nvo personaje vacio*/
            p = new Personaje();

            /*recorremos el listado de personajes*/
            foreach (Personaje personaje in LlenarCombos.getPersonajes())
            {
                /*Verificamos si el nombre del personaje recorrido corresponde al que buscamos*/
                if (personaje.name==nombre)
                {
                    /*si es asi, colocamos el personaje recorrido dentro de la variable */
                    p = personaje;

                    /*Finalizamos iteracion*/
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
          
            /*Buscamos el Personaje*/
            getBuscarPersonaje(valorSeleccionado);

            /*Listamos las peliculas del personaje*/
            listarPeliculas();

            /*Listamos las naves del personaje seleccionado*/
            listarNaves();

            /*Obtenemos el mundo del personaje seleccionado*/
            Mundo();

            /*llenamos los datos de los labels con los datos del personaje encontrado*/
            lblNombre.Text = p.name;          
            lblAltura.Text = p.height + " cm";
            lblAñoNacimiento.Text = p.birth_year;
            lblGenero.Text = p.gender;
            lblOjos.Text = p.eye_color;
            lblPelo.Text = p.hair_color;
            lblPiel.Text = p.skin_color;
            lblPeso.Text = p.mass + " kg";

            /*hacemos visible el panel*/
            tblpnlPersonaje.Visible = true;
        }


        
        private void Button1_Click_1(object sender, EventArgs e)
        {
            /*Cerramos la Aplicación*/
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
