using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;
namespace MB056625
{
    class Auto : IPojazd
    {
        public Silnik Silnik { get; private set; }

        public void Jedz() => Jedz(100);
        

        public void Jedz(int dystans)
        {
            
            string a="";
            for (int i = 0; i < dystans/this.Silnik.Spalanie; i++)
            {
                Console.Clear();
                Console.WriteLine(a);
                Console.Write(a);
                Silnik.Dzialaj();
                Console.WriteLine();
                Console.WriteLine(a+"    _____");
                Console.WriteLine(a+" __/ D D |___");
                Console.WriteLine(a+"|____________|");
                Console.WriteLine(a+"    O   O");
                System.Threading.Thread.Sleep(100);
                a += "--";
                
            }
            Console.Write(a+"Koniec paliwa :(");
        }

        public Auto(SilnikSpalinowy silnik)
        {
            Silnik = silnik;
        }
    }
}
