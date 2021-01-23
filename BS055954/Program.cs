using Dziedziczenie;
using System.Collections.Generic;
using System;

namespace BS055954
{
    class Program
    {

        public interface IPojazd {



        }

        public class KlasaTestowa : Silnik, IPojazd
        {
            public Silnik Silnik { get; set; }

            public void Jedz() => Jedz(100);


            public void Jedz(int dystans)
            {
                for (int i = 0; i < dystans; i++)
                {
                    Silnik.Dzialaj();
                }
            }

            public KlasaTestowa(int moc, double spalanie, string dzwiek) : base(moc, spalanie, dzwiek)
            {
            }
        }



        static void Main(string[] args)
        {
           



        }
    }
}
