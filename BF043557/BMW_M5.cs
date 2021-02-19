using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace BF043557
{
    class BMW_M5 : IPojazd
    {
        public Dziedziczenie.Silnik silnik { get; set; }

        public void Jedz()
        {
            silnik.Dzialaj();
        }

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                silnik.Dzialaj();
            }
        }
        public BMW_M5(V8 _silnik)
        {
            this.silnik = _silnik;
        }

    }
}