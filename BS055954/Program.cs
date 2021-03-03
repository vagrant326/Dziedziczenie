using Dziedziczenie;
using System.Collections.Generic;
using System;

namespace BS055954
{
    public class Program
    {


        public class KlasaTestowa : IPojazd
        {
            public Silnik Silnik { get; private set; }

            public void Jedz() => Jedz(100);


            public void Jedz(int dystans)
            {
                for (int i = 0; i < dystans; i++)
                {
                    Silnik.Dzialaj();
                }
            }



            public KlasaTestowa(int moc, double spalanie, string dzwiek)
            {
            }

            public KlasaTestowa(SilnikDiesla silnik)
            {
                Silnik = silnik;
            }
        }



        static void Main(string[] args)
        {
           



        }
    }
}
