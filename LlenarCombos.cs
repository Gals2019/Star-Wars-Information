using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonajeNmspc;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Reflection;

namespace AppInfoStarWars
{
    class LlenarCombos
    {        
     
        public LlenarCombos() { }

        /*Metodo para devolver un array de personajes desde un archivo Json Local*/
        public static List<Personaje> getPersonajes()
        {
            /*Creo una nueva lista vacia*/
            List<Personaje> ListadoDePersonajes = new List<Personaje>();

            /*Obtengo la ruta del archivo JSON desde donde se obtendran los datos para la lista*/
            String rutaArchivoPersonajes = Config.obtenerRuta("Personajes.json");

            /*leemos el archivo Json y lo guardo en una variable*/
            StreamReader sr = new StreamReader(rutaArchivoPersonajes);            
            String json = sr.ReadToEnd();

            /*Lo convierto de String a un JObject*/
            JObject jo = JObject.Parse(json);

            /*Busco el array dentro del json con los objetos que requiero*/            
            JToken token = (jo["Personajes"] as JArray);

            /*Iteramos dentro del array*/
            foreach (var item in token)
            {
                /*Instancio un nuevo objeto y luego guardo el item recorrido dentro de ese array*/
                Personaje p = new Personaje();

                p = JsonConvert.DeserializeObject<Personaje>(item.ToString());

                /*Agrego ese objeto a la lista*/
                ListadoDePersonajes.Add(p);
            }
            /*Devuelvo la lista*/
            return ListadoDePersonajes;
        }

        /*Idem getPersonajes()*/
        public List<Pelicula> getPeliculas() {
            List<Pelicula> listaPeliculas = new List<Pelicula>();

            

            String rutaArchivoPeliculas = Config.obtenerRuta("Peliculas.json");

            StreamReader sr = new StreamReader(rutaArchivoPeliculas);

            String json = sr.ReadToEnd();

            JArray arrayPeliculas = JArray.Parse(json);

            foreach (var item in arrayPeliculas)
            {
                Pelicula peli = new Pelicula();

                peli = JsonConvert.DeserializeObject<Pelicula>(item.ToString());

                listaPeliculas.Add(peli);
            }



            return listaPeliculas;

        }

        /*Idem getPersonajes()*/
        public List<Mundo> getMundos() {

            List<Mundo> listaMundos = new List<Mundo>();

            String rutaArchivoMundos = Config.obtenerRuta("Mundos.json");

            StreamReader sr = new StreamReader(rutaArchivoMundos);
            String json = sr.ReadToEnd();

            JObject jo = JObject.Parse(json);

            JToken token = (jo["Mundos"] as JArray);

            foreach (var item in token)
            {
                Mundo mun = new Mundo();

                mun = JsonConvert.DeserializeObject<Mundo>(item.ToString());

                listaMundos.Add(mun);
            }

            return listaMundos;
                
        }

        /*Idem getPersonajes()*/
        public List<Especies> getEspecies() {
            List<Especies> listadoEspecies = new List<Especies>();

            String rutaArchivoMundos = Config.obtenerRuta("Especies.json");

            StreamReader sr = new StreamReader(rutaArchivoMundos);
            String json = sr.ReadToEnd();

            JObject jo = JObject.Parse(json);

            JToken token = (jo["Especies"] as JArray);

            foreach (var item in token)
            {
                Especies esp = new Especies();

                esp = JsonConvert.DeserializeObject<Especies>(item.ToString());

                listadoEspecies.Add(esp);
            }

            return listadoEspecies;
        }

        /*Idem getPersonajes()*/
        public List<Nave> getNaves()
        {
            List<Nave> listadoNaves = new List<Nave>();

            String rutaArchivoMundos = Config.obtenerRuta("Naves.json");

            StreamReader sr = new StreamReader(rutaArchivoMundos);
            String json = sr.ReadToEnd();

            JObject jo = JObject.Parse(json);

            JToken token = (jo["Naves"] as JArray);

            foreach (var item in token)
            {
                Nave nav = new Nave();

                nav = JsonConvert.DeserializeObject<Nave>(item.ToString());

                listadoNaves.Add(nav);
            }

            return listadoNaves;
        }

        /*Idem getPersonajes()*/
        public List<Vehiculo> getVehiculos()
        {
            List<Vehiculo> listadoVehiculos = new List<Vehiculo>();

            String rutaArchivoMundos = Config.obtenerRuta("Vehiculos.json");

            StreamReader sr = new StreamReader(rutaArchivoMundos);
            String json = sr.ReadToEnd();

            JObject jo = JObject.Parse(json);

            JToken token = (jo["Vehiculos"] as JArray);

            foreach (var item in token)
            {
                Vehiculo nav = new Vehiculo();

                nav = JsonConvert.DeserializeObject<Vehiculo>(item.ToString());

                listadoVehiculos.Add(nav);
            }

            return listadoVehiculos;
        }

        

        /*public void llenarList( Object objeto, String Buscar,ListBox lista) {

            Type tipoObjeto = objeto.GetType();
            // Type tipoClase = Clase.GetType();

           

            PropertyInfo[] propiedades = tipoObjeto.GetProperties();

            foreach (PropertyInfo item in propiedades)
            {
                if (item.Name==Buscar)
                {
                   
                }
            }

        }*/
    }
}
