using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ballena ballena1 = new Ballena("Migaloo");
            Caballo caballo1 = new Caballo("Bucéfalo");
            ballena1.Nadar();
            Console.WriteLine("El caballo tiene " + caballo1.CantidadPatas() + " patas");
        }
    }

    interface ICantidadPatas
    {
        int CantidadPatas();
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

    class Humano : Mamiferos, ICantidadPatas
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {
          
        }

        public void Pensar()
        {
            Console.WriteLine("El humano puede pensar");
        }

        public int CantidadPatas()
        {
            return 2;
        }
    }

    class Caballo : Mamiferos, ICantidadPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void Galopar()
        {
            Console.WriteLine("El caballo puede galopar");
        }

        public int CantidadPatas()
        {
            return 4;
        }

    }
}
