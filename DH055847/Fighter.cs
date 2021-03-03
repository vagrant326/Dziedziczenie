using System;
using Dziedziczenie;

namespace DH055847
{

    public class Fighter : IPojazd
    {
        KuatDriveYards TieEngine;

        public void Jedz()
        {
            Jedz(9000);
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

  

}
