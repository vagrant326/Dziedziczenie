﻿using System;
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
                        Console.Clear();
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
                    Console.Clear();
                    Console.WriteLine("Wrong key");
                    komunikat = "Naciśnij jeszcze raz \"F\" ";
                    Thread.Sleep(1000);
                    Console.Clear();
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
                Console.Clear();
                Console.WriteLine("Prędkość: {0} km/h", Predkosc);
                Console.WriteLine("Dystans: {0} km", i);
                Console.WriteLine($"Spalanie: {Math.Round(Predkosc++ / Silnik.Moc * Silnik.Spalanie, 2)} l/100km");
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