using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Mamiferos
    {
        public Mamiferos(String nombreMamifero)
        {
            Console.WriteLine("Mi nombre es " + nombreMamifero);
        }
    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("La ballena puede nadar");
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {
          
        }

        public void Pensar()
        {
            Console.WriteLine("El humano puede pensar");
        }
    }

    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void Galopar()
        {
            Console.WriteLine("El caballo puede galopar");
        }

    }
}
