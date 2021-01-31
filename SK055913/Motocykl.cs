using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace SK055913
{
    class Motocykl : IPojazd
    {
        public Boxer Boxer { get; private set; }
        public int Paliwo { get; set; }

        private const int POJEMNOSC_ZBIORNIKA = 1000;
        public String WskaznikPaliwa { get;  set; }
        public Motocykl(Boxer boxer)
        {
            Paliwo = 1000;
            WskaznikPaliwa = "||||||||||";
            Boxer = boxer;
        }
        public void Jedz() => Jedz(100);
        public void Jedz(int dystans)
        {
            Console.WriteLine(WskaznikPaliwa);
            Boxer.Uruchom();
            for (int i = 0; i < dystans; i++)
            {
                if (i % 10 == 0 && i>9)
                {
                    AktualizujWskaznik(i / 10);
                }
                Paliwo -= 10;
                if(Paliwo>0)
                    Boxer.Dzialaj();
                else
                {
                    Console.WriteLine("Brak paliwa");
                    break;
                }
            }
        }

        public void AktualizujWskaznik(int krok)
        {

            char[] wskaznikPaliwa = WskaznikPaliwa.ToCharArray();
            wskaznikPaliwa[wskaznikPaliwa.Length - (krok + 1)] = '-';
            WskaznikPaliwa = new string (wskaznikPaliwa);
            Console.WriteLine(WskaznikPaliwa);
        }
    }
}
