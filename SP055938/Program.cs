﻿using Dziedziczenie;
using System;
using System.Threading.Tasks;

namespace SP055938
{
    public class MyCar : IPojazd
    {
        public void Jedz() => Jedz(60); //domyślnie zostanie użyta wartość 60

        public void Jedz(int dystans) //wprawia auto w ruch i wyświetla jego dane
        {
            var kamaz = new MyCar();

            Odpalanie();
            Task.Delay(1000).Wait();

            /*
             * *poprawka 1* usunąłem funkcję main
             * *poprawka 2* usunałem niepotrzebną zmienną
             * *poprawka 3* Console.SetCursorPosition przeskoczy i nadpisze tylko te linie w konsoli 
             * które wyświetla moja implementacja a nie tak jak przy Console.Clear
             * *poprawka 4* przeniosłem "ruch" samochodziku do jednej funkcji
             */
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 5);
            kamaz.Poruszanie(dystans);

        }

        public void Poruszanie(int dystans)
        {
            Random rand = new Random();
            int zm = rand.Next(0, 2);
            // zm = 0; // 0 = jedzie, 1 - wybuch
            var dane = new MyEngine();
            string next = " ";


            if (zm == 0)
            {
                Jedziemy(next, dane, dystans);
            }
            else
            {
                JedziemyNiedaleko(next, dane, dystans);
            }
        }

        static void Odpalanie() //wyświetla auto i dźwięk silnika
        {
            var a = new MyEngine();
            Console.WriteLine("           _  ");
            Console.WriteLine($"|       | | |  ");
            Console.WriteLine($" --O-O----O-/  ");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            for (int i = 0; i < 10; i++) // dźwięk odpalanego silnika
            {
                Task.Delay(70).Wait();
                a.Dzialaj();
            }
            Console.WriteLine("Odpalił!");
        }

        static void Jedziemy(string next, MyEngine dane, int dystans)
        {

            for (int j = 0; j < dystans; j++)
            {
                Ruch(ref next, dane, dystans, j);
            }

            Console.WriteLine(next + "            _");
            Console.WriteLine(next + $" |       | | |");
            Console.WriteLine(next + $" \\--O-O----O-/  ");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"Dojechałeś.                                                                          ");
        }

        static void JedziemyNiedaleko(string next, MyEngine dane, int dystans)
        {
            for (int j = 0; j < dystans; j++)
            {
                Ruch(ref next, dane, dystans, j);

                if (j == (dystans / 2))
                {
                    next = "".PadLeft(j);
                    Console.WriteLine(next + "  /---------\\");
                    Console.WriteLine(next + $" /  / Boom!/ \\");
                    Console.WriteLine(next + $"/  O   /  o / \\");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine($"Już nie jedziemy! :( Proszę wyobrazić sobie efektowne wybuchy");
                    break;
                }
            }
        }

        static void Ruch(ref string next, MyEngine dane, int dystans, int j)
        {
            next = "".PadLeft(j);
            Console.WriteLine(next + "            _");
            Console.WriteLine(next + $" |       | | |");
            Console.WriteLine(next + $" \\--O-O----O-/  ");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"Jedziemy! Twój Kamaz ma {dane.GetMoc()}KM i akutalne spalanie {dane.GetSpalanie()}l/100km.");

            Task.Delay(40).Wait();

            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 5);
        }
    }

    public class MyEngine : Silnik
    {
        public MyEngine() : base(moc: 360, spalanie: 35, dzwiek: "pyr")
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
}
