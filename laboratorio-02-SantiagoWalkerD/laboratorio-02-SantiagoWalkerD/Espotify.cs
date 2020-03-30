using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio_02_SantiagoWalkerD
{
    public class Espotifai
    {
        public string genero1;
        public string album1;
        public string artista1;
        public string nombre1;

        public Espotifai(string Agenero, string Aartista, string Aalbum, string Anombre)
        {
            this.genero1 = Agenero;
            this.artista1 = Aartista;
            this.album1 = Aalbum;
            this.nombre1 = Anombre;
        }
        string[] canciones = { "reaggeton", "Myke Towers", "Easy Money", "Girl" }; // AGREGAR INFORMACION DE LA NUEVA CANCION 
                                                                                   // { GENERO, ARTISTA, ALBUM, NOMBRE }

        public bool AgregarCancion()
        {
            if (genero1 == canciones[0] && artista1 == canciones[1] && album1 == canciones[2] && nombre1 == canciones[3])
            {                 
                return false;                
            }

            return true ;
        }
        
        public void VerCanciones()
        {

            Console.WriteLine("estas son todas las canciones:");
            Console.WriteLine(" ");
            Console.WriteLine("genero: " + canciones[0] + ", artista: " + canciones[1] + ", album: " + canciones[2] + ", nombre: " + canciones[3]);

        }

    }
}
