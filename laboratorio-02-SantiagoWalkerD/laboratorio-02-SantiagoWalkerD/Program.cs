using System;

namespace laboratorio_02_SantiagoWalkerD
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("pop", "Ellie Goulding", "Lights", "Lights");
            Cancion cancion2 = new Cancion("pop", "Micheal Jackson", "Thriller", "Thriller");
            Cancion cancion3 = new Cancion("rock", "Elvis Presley", "Live 1969", "Hound Dog");

            Espotifai canciones1 = new Espotifai("pop", "Ellie Goulding", "Lights", "Lights");
            Espotifai canciones2 = new Espotifai("pop", "Micheal Jackson", "Thriller", "Thriller");
            Espotifai canciones3 = new Espotifai("rock", "Elvis Presley", "Live 1969", "Hound Dog");

            //x1 = cancion1.genero;
            //x2 = cancion1.artista;
            //x3 = cancion1.album;
            //x4 = cancion1.nombre;


            Console.WriteLine("bienvenidos a Espotifai");
            Console.WriteLine("  ");

            Console.WriteLine(cancion1.informacion());
            Console.WriteLine(cancion2.informacion());
            Console.WriteLine(cancion3.informacion());

            Console.WriteLine("  ");




            if (canciones1.AgregarCancion() == false)
            {
                Console.WriteLine("invalido, corra de nuevo el programa");
            }
            else if (canciones2.AgregarCancion() == false)
            {
                Console.WriteLine("invalido, corra de nuevo el programa");
            }
            else if (canciones3.AgregarCancion() == false)
            {
                Console.WriteLine("invalido, corra de nuevo el programa");
            }
            else
            {
                Console.WriteLine("cancion añadida correctamente");
                Console.WriteLine(" ");
                canciones1.VerCanciones();
                Console.WriteLine(cancion1.informacion());
                Console.WriteLine(cancion2.informacion());
                Console.WriteLine(cancion3.informacion());
            }
            Console.WriteLine("  ");
        }
    }
}
