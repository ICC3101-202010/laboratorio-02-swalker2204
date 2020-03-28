using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio_02_SantiagoWalkerD
{
    public class Cancion
    {
        public string genero;
        public string album;
        public string artista;
        public string nombre;

        public Cancion(string Agenero, string Aartista, string Aalbum, string Anombre)
        {
            this.genero = Agenero;
            this.artista = Aartista;
            this.album = Aalbum;
            this.nombre = Anombre;
        }
        public string informacion()
        {
            string z = ("genero: " + genero + ", artista: " + artista + ", album: " + album + ", nombre: " + nombre);
            return z;
        }

    }



    
}
