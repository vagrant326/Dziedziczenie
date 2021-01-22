using System;
using Dziedziczenie;

namespace DH055847
{

    class Fighter : IPojazd
    {
        KuatDriveYards TieEngine;

        public void Jedz()
        {
            Jedz(2137);
            Console.Write($"Pew pew pew");
        }
        public void Jedz(int dystans)
        {
            TieEngine.Dzialaj();

        }

        public Fighter()
            {
            TieEngine = new KuatDriveYards(9000, 20);
            }



    }

    class KuatDriveYards : Silnik
    {

        public KuatDriveYards(int moc, double spalanie):base( moc, spalanie, "eeeeeeEEEEEEEEUUUUUUUOOOOOOOOOOooooooooooooo")
        {

        }

    }

        class Program
    {
        static void Main(string[] args)
        {
            Fighter tieInterceptor = new Fighter();
            tieInterceptor.Jedz();
            
        }
    }
}
