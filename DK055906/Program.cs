using System;
using Dziedziczenie;

namespace DK055906
{
    class Program
    {
        
        static void Main()
        {
            Car Audi = new Car(new SilnikSpalinowy(1000,20));
            Audi.uruchom();

            
        }
    }
}