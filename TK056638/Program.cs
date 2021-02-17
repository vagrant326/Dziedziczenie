using System;
using Dziedziczenie;

namespace TK056638
{
    class Program
    {
        static void Main(string[] args)
        {
            TeslaSilnik silnik = new TeslaSilnik(77, 7.4, "Łuuuddduudduu", 101, Voltage.HighVoltage);
            Taxi taxi = new Taxi(silnik);
            
            taxi.Jedz(100);
            
        }
    }
}