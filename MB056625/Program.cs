using System;
using Dziedziczenie;

namespace MB056625
{
    class Program
    {
        static void Main(string[] args)
        {
            SilnikSpalinowy p = new SilnikSpalinowy(1, 3, "Wrumm");
            Auto a = new Auto(p);
            a.Jedz();
        }
    }
}
