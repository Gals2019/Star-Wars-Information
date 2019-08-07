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
        /*Metodo para listar Peliculas del personaje seleccionado*/
        private void listarPeliculas()
        {
            /*Limpiamos la lista*/
            lstPeliculas.Items.Clear();

            /*Iteramos dentro del listado de peliculas del Archivo Peliculas.json*/
            foreach (Pelicula pelicula in llc.getPeliculas())
            {
                /*iteramos dentro del array de films del personaje encontrado*/
                foreach (String item in p.films)
                {
                    /*verificamos si el film recorrido del personaje encontrado es igual al film recorrido en 
                     iteracion anterior*/
                    if (item==pelicula.url)
                    {
                        /*se agrega el titulo de la pelicula al listado*/
                        lstPeliculas.Items.Add(pelicula.title);

                        /*terminamos iteracion del film del personaje y pasamos a la siguiente pelicula*/
                        break;
                    }
                }
            }

        }
        /*metodo para buscar las naves del personaje*/
        private void listarNaves()
        {
            /*limpamos la lista*/
            lstNaves.Items.Clear();

                /*recorremos el array de naves del personaje*/
                foreach (String item in p.starships)
                {
                       /*iteramos dentro del array del archivo Naves.json*/
                    foreach (Nave nave in llc.getNaves())
                    {
                        /*Verificamos que la url de la nave recorrida del array del personaje sea igual al del array de naves del json*/
                        if (item==nave.url)
                        {
                            /*guardamos el nombre de la nave encontrada dentro del listado*/
                            lstNaves.Items.Add(nave.name);
                            
                            /*terminamos iteracion del array del json*/
                            break;
                        }
                    }
                }

        }

        /*metodo para buscar el nombre del mundo del personaje*/
        private void Mundo() {
            /*iteramos dentro del array del json Mundos.json*/
            foreach (Mundo mundo in llc.getMundos())
            {
                /*verificamos si la url de la propiedad homeworld del personaje encontrado es igual al del mundo del json*/
                if (mundo.url==p.homeworld)
                {
                    /*Asignamos el nombre del mundo recorrido al lbl correspondiente*/
                    lblHogar.Text = mundo.name;

                    /*finalizamos iteracion*/
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
