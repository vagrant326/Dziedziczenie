using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DH055847;
using DK055906;
using Dziedziczenie;
using MB056625;
using MK055917;
using MS055950;
using PM055928;
using MZ048257;
using SP055938;
using TK056638;

namespace Prezentacja
{
    public class Helper
    {
        public static IEnumerable<IPojazd> Zaladuj()
        {
            return new List<IPojazd>()
            {
                new BMW_M2(){ Silnik = new Silnik_BMW_V8(500, 3, 15.0, "") },
                new BS055954.Program.KlasaTestowa(new SilnikDiesla(100, 10)),
                new Fighter(),
                new DK055906.Car(new DK055906.SilnikSpalinowy(1000,20, 400)),
                new Auto(new MB056625.SilnikSpalinowy()),
                new Tir(new MK055917.SilnikSpalinowy(1000,50)),
                new Automobil(new V8(500, 20)),
                new MZ048257.Car(new DieselSOHC(130, 5.5, "No zarycz! No!")),
                new BMW_M2(),
                new MyCar(),
                new Taxi(new TeslaSilnik(77, 7.4, "Łuuuddduudduu", 101, Voltage.HighVoltage))
            };
        }

    }
}
