using System;
using Dziedziczenie;

namespace TK056638
{
    public class Taxi : IPojazd
    {
        public TeslaSilnik Engine { get; set; }

        public Taxi(TeslaSilnik engine)
        {
            Engine = engine;
        }


        public void Jedz()
        {
            Random rnd = new Random();
            Jedz(rnd.Next(1,100));
        }

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                if (Engine.Voltage == Voltage.LowVoltage)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Engine.Dzialaj();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Engine.Dzialaj();
                    
                }
            }
        }
    }
}