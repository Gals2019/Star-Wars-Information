using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PersonajeNmspc;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AppInfoStarWars
{
    class Config
    {

        /*Funcion para obtener la ruta de la carpeta*/
        public static String obtenerRuta(String nombreArchivo)
        {
            String ruta = "";
            /*concateno la ruta de donde esta la app con el nombre de la carpeta donde seran 
             creados los archivos JSON*/
            ruta = Directory.GetCurrentDirectory() + @"\Archivos";
            /*si no existe la carpeta la creo*/
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            /*se suma a la concatenacion anterior el nombre del archivo que llega por paramtero*/
            ruta += @"\"+nombreArchivo;

            /*Devuelvo la ruta del archivo*/
            return ruta;

        }
        /*Funcion para crear archivos en caso de que la carpeta no exista aun*/
        public static void CrearArchivo(List<String> Archivos)
        {
            /*Declaro una bandera en true*/
            bool existeArchivo = true;      

      
            /*Recorro el listado con los nombres de los archivos a buscar*/
            foreach (var item in Archivos)
            {
                /*Llamo a la funcion para obtener la ruta de la app*/
                String NombreArchivo = obtenerRuta(item);

                /*Verifico existencia o no de los archivos dentro de la ruta*/
                if (!File.Exists(NombreArchivo))
                {
                    /*Si no existe la bandera cambia a false*/
                    existeArchivo = false;
                    /*Creo el archivo dentro de la ruta*/
                    using (var fileStream = File.Create(NombreArchivo))
                    {
                        /*cierro el fileStream*/
                        fileStream.Dispose();

                        
                    }

                }
            }
            /*una vez terminado si la bandera esta en false llamo a la funcion LLenarJsons*/
            if (!existeArchivo)
            {
                LlenarJsons();
            }

        }

        /*Funcion que llamara a las demas funciones para llenar los Jsons creados*/
        private static void LlenarJsons() {

            llenarPersonajesJSON();
            llenarPeliculasJSON();
            llenarMundosJSON();
            llenarEspeciesJSON();
            llenarNavesJSON();
            llenarVehiculosJSON();
        }
        public static void llenarPersonajesJSON()
        {
            /*declaro variable vacia para ser llenada despues*/
            var personaje = "";
            String jsonObjeto = "";
            
            /*Recorro cada direccion de la api (sabemos que tienen 9 paginas)*/
            for (int i = 1; i < 10; i++)
            
            {
                /*declaro variable webCliente para hacer las peticiones*/
                WebClient wc = new WebClient();
                
                /*url a la que se hara la peticion*/
                var url = "https://swapi.co/api/people/?page=" + i;
                
                /*en la variable personaje almaceno el json recibido*/
                personaje = wc.DownloadString(url);

                /*Creo una variable del tipo JObject para almacenar lo recibido*/
                JObject jo = JObject.Parse(personaje);              

                /*De la var anterior, pido solo los elementos que esten dentro del array results
                 del Json y los guardo en token*/
                JToken token = (jo["results"] as JArray);

                /*Declaro variable para saber las vueltas que da por cada resultado*/
                int contador = 1;

                /*Recorro cada resultado dentro de la var token*/
                foreach (var item in token)
                {
                    /*Creo n nuevo personaje vacio*/
                    Personaje p = new Personaje();

                    /*Deserializo el elemento recorrido dentro de token en uno del tipo Personaje, y lo guardo*/
                    p = JsonConvert.DeserializeObject<Personaje>(item.ToString());

                    /*Aca realizo mi propia estructura Json*/
                    if (i<9)
                    {
                        /*si la direcion url esta por debajo de la 9, es decir, la vuelta es menor a 9 del
                         foreach principal, convertira el Personaje almacenado a Json, le concatenara una "," para
                         separar de los siguientes objetos y lo agregara a la variable JsonObjeto*/
                        jsonObjeto += JsonConvert.SerializeObject(p) + ",";
                    }
                    /*si la direccion url ya es la última*/
                    else
                    {
                        /*verificamos que no sea el ultimo objeto del Json devuelto por la ultima pagina url*/
                        if (contador<token.Count<JToken>())
                        {
                            jsonObjeto += JsonConvert.SerializeObject(p) + ",";
                            /*sumamos 1 al contador de objetos del Json*/
                            contador++;
                        }
                        /*si es el ultimo objeto del Json*/
                        else
                        {
                            /*Procedemos igual que con los anteriores, pero no le agregamos la ","
                             ya que es el ultimo Objeto del ultimo JSON*/
                            jsonObjeto += JsonConvert.SerializeObject(p);
                        }
                    }
                    

                 
                }

            }

            /*Creo un  Json con un array llamado Personajes y lo guardo como String en una variable*/
            jsonObjeto = "{\"Personajes\":[" + jsonObjeto + "]}";
           
            /*Escribo dentro del archivo Personajes.Json la variable anterior. Convirtiendo asi en un archivo JSON
             que puedo usar como base de datos*/
            System.IO.File.WriteAllText(obtenerRuta("Personajes.json"), jsonObjeto);

        }
        /*Idem Metodo llenarPersonajesJson*/
        private static void llenarPeliculasJSON()
        {
            var film = "";

           
            WebClient wc = new WebClient();

            var url = "https://swapi.co/api/films/";

            film = wc.DownloadString(url);

            JObject jo = JObject.Parse(film);

            JToken token = (jo["results"] as JArray);

            System.IO.File.WriteAllText(obtenerRuta("Peliculas.json"), token.ToString());

        }

        /*Idem Metodo llenarPersonajesJson*/
        private static void llenarMundosJSON()
        {
            var mundo = "";
            String jsonObjeto = "";

            for (int i = 1; i < 8; i++)

            {
                WebClient wc = new WebClient();

                var url = "https://swapi.co/api/planets/?page=" + i;

                mundo = wc.DownloadString(url);

                JObject jo = JObject.Parse(mundo);

                JToken token = (jo["results"] as JArray);

                int contador = 1;

                foreach (var item in token)
                {
                    Mundo m = new Mundo();

                    m = JsonConvert.DeserializeObject<Mundo>(item.ToString());


                    if (i < 7)
                    {
                        jsonObjeto += JsonConvert.SerializeObject(m) + ",";
                    }
                    else
                    {
                        if (contador < token.Count<JToken>())
                        {
                            jsonObjeto += JsonConvert.SerializeObject(m) + ",";
                            contador++;
                        }
                        else
                        {
                            jsonObjeto += JsonConvert.SerializeObject(m);
                        }
                    }



                }

            }

            jsonObjeto = "{\"Mundos\":[" + jsonObjeto + "]}";
            // jsonObjeto += JsonConvert.SerializeObject(listaPersonajes);

            System.IO.File.WriteAllText(obtenerRuta("Mundos.json"), jsonObjeto);


        }

        /*Idem Metodo llenarPersonajesJson*/
        private static void llenarEspeciesJSON()
        {

            var especie = "";
            String jsonObjeto = "";

            for (int i = 1; i < 5; i++)

            {
                WebClient wc = new WebClient();

                var url = "https://swapi.co/api/species/?page=" + i;

                especie = wc.DownloadString(url);

                JObject jo = JObject.Parse(especie);

                JToken token = (jo["results"] as JArray);

                int contador = 1;

                foreach (var item in token)
                {
                    Especies m = new Especies();

                    m = JsonConvert.DeserializeObject<Especies>(item.ToString());


                    if (i < 4)
                    {
                        jsonObjeto += JsonConvert.SerializeObject(m) + ",";
                    }
                    else
                    {
                        if (contador < token.Count<JToken>())
                        {
                            jsonObjeto += JsonConvert.SerializeObject(m) + ",";
                            contador++;
                        }
                        else
                        {
                            jsonObjeto += JsonConvert.SerializeObject(m);
                        }
                    }



                }

            }

            jsonObjeto = "{\"Especies\":[" + jsonObjeto + "]}";
            // jsonObjeto += JsonConvert.SerializeObject(listaPersonajes);

            System.IO.File.WriteAllText(obtenerRuta("Especies.json"), jsonObjeto);


        }

        /*Idem Metodo llenarPersonajesJson*/
        private static void llenarNavesJSON()
        {
            var nave = "";
            String jsonObjeto = "";

            for (int i = 1; i < 5; i++)

            {
                WebClient wc = new WebClient();

                var url = "https://swapi.co/api/starships/?page=" + i;

                nave = wc.DownloadString(url);

                JObject jo = JObject.Parse(nave);

                JToken token = (jo["results"] as JArray);

                int contador = 1;

                foreach (var item in token)
                {
                    Nave m = new Nave();

                    m = JsonConvert.DeserializeObject<Nave>(item.ToString());


                    if (i < 4)
                    {
                        jsonObjeto += JsonConvert.SerializeObject(m) + ",";
                    }
                    else
                    {
                        if (contador < token.Count<JToken>())
                        {
                            jsonObjeto += JsonConvert.SerializeObject(m) + ",";
                            contador++;
                        }
                        else
                        {
                            jsonObjeto += JsonConvert.SerializeObject(m);
                        }
                    }



                }

            }

            jsonObjeto = "{\"Naves\":[" + jsonObjeto + "]}";
            // jsonObjeto += JsonConvert.SerializeObject(listaPersonajes);

            System.IO.File.WriteAllText(obtenerRuta("Naves.json"), jsonObjeto);


        }

        /*Idem Metodo llenarPersonajesJson*/
        private static void llenarVehiculosJSON() {

            var vehiculo = "";
            String jsonObjeto = "";

            for (int i = 1; i < 5; i++)

            {
                WebClient wc = new WebClient();

                var url = "https://swapi.co/api/vehicles/?page=" + i;

                vehiculo = wc.DownloadString(url);

                JObject jo = JObject.Parse(vehiculo);

                JToken token = (jo["results"] as JArray);

                int contador = 1;

                foreach (var item in token)
                {
                    Vehiculo m = new Vehiculo();

                    m = JsonConvert.DeserializeObject<Vehiculo>(item.ToString());


                    if (i < 4)
                    {
                        jsonObjeto += JsonConvert.SerializeObject(m) + ",";
                    }
                    else
                    {
                        if (contador < token.Count<JToken>())
                        {
                            jsonObjeto += JsonConvert.SerializeObject(m) + ",";
                            contador++;
                        }
                        else
                        {
                            jsonObjeto += JsonConvert.SerializeObject(m);
                        }
                    }



                }

            }

            jsonObjeto = "{\"Vehiculos\":[" + jsonObjeto + "]}";
            // jsonObjeto += JsonConvert.SerializeObject(listaPersonajes);

            System.IO.File.WriteAllText(obtenerRuta("Vehiculos.json"), jsonObjeto);



        }
    }
}
