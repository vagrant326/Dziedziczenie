using Dziedziczenie;
using System;
using System.Threading;

namespace SP055938
{
    class MyCar : IPojazd
    {
        public void Jedz() => Jedz(20); //jeśli nie zostanie podana przez użytkownika żadna wartość to zostanie użyta domyślna (20)

        public void Jedz(int dystans) //wprawia auto w ruch i wyświetla jego dane
        {
            var dane = new MyEngine();
            string next;
            for (int j = 0; j < dystans; j++)
            {
                Console.Clear();
                next = "".PadLeft(j);
                Console.WriteLine(next + "           _");
                Console.WriteLine(next + $"|       | | |");
                Console.WriteLine(next + $" --O-O----O-/  ");
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine($"Twój Kamaz ma {dane.GetMoc()}KM i akutalne spalanie {dane.GetSpalanie()}l/100km.");
                Thread.Sleep(150); // zakazana technika ;)
            }
        }
    }

    class MyEngine : Silnik
    {
        public MyEngine() : base(360, 35, "pyr")
        {

        }

        public MyEngine(int moc, double spalanie, string dzwiek) : base(moc, spalanie, dzwiek)
        {
        }

        public string GetMoc() // wyświetla moc 
        {
            return Moc + " ";
        }
        public string GetSpalanie()  //wyświetla spalanie
        {
            return Spalanie + " ";
        }
    }
    class Program
    {
        static void NieOdpalil()  //wyświetla że silnika nie udało się odpalić
        {
            Console.Clear();
            Console.WriteLine("           _  ");
            Console.WriteLine($"|       | | |  Silnik nie odpala");
            Console.WriteLine($" --O-O----O-/  Tym razem nie jedziemy :(");
            Console.WriteLine("-------------------------------------------------------------------------------");
        }
        static void Odpalanie() //wyświetla auto i dźwięk silnika
        {
            var a = new MyEngine();
            Console.WriteLine("           _  ");
            Console.WriteLine($"|       | | |  ");
            Console.WriteLine($" --O-O----O-/  ");
            Console.WriteLine("-------------------------------------------------------------------------------");
            string next;
            for (int i = 0; i < 10; i++) // dźwięk odpalanego silnika
            {
                Thread.Sleep(100);
                a.Dzialaj();
            }
        }

        static void Main(string[] args)
        {
            int wybuch;
            int odpalil;

            Random rand = new Random();
            var kamaz = new MyCar();


            wybuch = rand.Next(0, 9);
            odpalil = rand.Next(11, 20);
            #region
            //wybuch = 1; //jedzie    // żeby nie czekać aż wylosują się odpowienie liczby 
            //odpalil = 11;           // można użyc tych przypisań dla każdego przypadku

            //wybuch = 1; //nie jedzie
            //odpalil = 16;

            //wybuch = 8;  //wybuchł
            #endregion
            if (wybuch <= 5) // przypadek gdy z randomowych liczb wypadnie więcej niż mniej niż 5
            {
                if (odpalil <= 15) // przypadek gdy z randomowych liczb wypadnie więcej niż mniej niż 15
                {

                    Odpalanie();
                    Console.WriteLine("Odpalił!");
                    Console.WriteLine("Jak daleko chcesz jechać? (wartość powyżej 20 trwa wieczność ;))");
                    kamaz.Jedz(int.Parse(Console.ReadLine()));
                }
                else // przypadek gdy z randomowych liczb wypadnie więcej niż 15
                {
                    Odpalanie();
                    Console.Write("Nie odpalił!");
                    Thread.Sleep(1000);
                    NieOdpalil();
                    Environment.Exit(0);
                }
            }
            else // przypadek gdy z randomowych liczb wypadnie więcej niż 5
            {
                Console.WriteLine("  /---------\\");
                Console.WriteLine(" /  / Boom!/ \\");
                Console.WriteLine("/  O   /  o / \\");
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("Ewidentnie coś poszło nie tak :(");
                Environment.Exit(0);
            }
        }
    }
}
