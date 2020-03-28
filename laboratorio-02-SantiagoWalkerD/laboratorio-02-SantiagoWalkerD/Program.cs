using System;

namespace laboratorio_02_SantiagoWalkerD
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion = new Cancion("pop", "Ellie Goulding", "Lights", "Lights");

            Console.WriteLine(cancion.informacion());

        }
    }
}
