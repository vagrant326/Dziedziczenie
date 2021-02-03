using System;

namespace MB056625
{
    class Program
    {
        static void Main(string[] args)
        {
            SilnikSpalinowy p = new SilnikSpalinowy();
            Auto a = new Auto(p);
            a.Jedz();
        }
    }
}
