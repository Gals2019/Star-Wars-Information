using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AppInfoStarWars
{
    class Sonidos
    {
        public static void ReproducirSonido(String NombreSonido) {

            String ruta = "";

            ruta = Directory.GetCurrentDirectory();

            SoundPlayer sonido = new SoundPlayer(ruta+@"\"+NombreSonido);
            sonido.Play();

            
        }
    }
}
