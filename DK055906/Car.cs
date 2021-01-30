using System;
using System.Runtime.CompilerServices;
using Dziedziczenie;
using System.Threading;

namespace DK055906
{
    public class Car : IPojazd
    {
        public Silnik Silnik { get; set; }

        public void uruchom()
        {
            string key;
            bool check = false;
            string komunikat = "Naciśnij ";
            
            while (check == false)
            {
                
            Console.WriteLine(komunikat + "\"f\"");
            key = Console.ReadLine();

                if (key == "f" || key == "F")
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine("=======");
                        Console.WriteLine("Uruchamianie silnika:\n");
                        Console.WriteLine($"Sprawdzanie błędów: {i * 10}%");
                        Console.WriteLine("");
                        
                        Thread.Sleep(300);
                        
                        

                        check = true;
                    }
                    Jedz(100);
                }
                else
                {
                    Console.WriteLine("=======");
                    Console.WriteLine("Wrong key");
                    komunikat = "Naciśnij jeszcze raz \"F\" ";
                    Thread.Sleep(1000);
                    Console.WriteLine("=======");
                    check = false;
                }
            }
        }

        public void Jedz()
        {
            throw new System.NotImplementedException();
        }
        public void Jedz(int dystans)
        {
            double Predkosc = 1; 
            
            for (int i = 0; i < dystans; i++)
            {
                Console.WriteLine("=======");
                Console.WriteLine("Prędkość: {0} km/h", Predkosc);
                Console.WriteLine("Dystans: {0} km", i);
                Console.WriteLine($"Spalanie: {Math.Round(Predkosc++ / SilnikSpalinowy.Vmax * Silnik.Spalanie, 2)} l/100km");
                Console.WriteLine(i % 2 == 0 ? Silnik.Dzwiek : Silnik.Dzwiek.ToUpper());
                Thread.Sleep(350);
            }
        }

        public Car(SilnikSpalinowy silnik)
        {
            Silnik = silnik;
        }
    }
}