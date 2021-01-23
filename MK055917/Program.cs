using System;
using System.Threading;

namespace MK055917
{
    public class Tir : Dziedziczenie.IPojazd
    {
        public Silnik Silnik { get; set; }

        public void Odpal()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("===== Uruchamianie silnika =====\n");
                Console.WriteLine($"Prędkość maksymalna: {Silnik.Vmax}");
                Console.WriteLine($"Spalanie: {Silnik.Spalanie}\n");
                Console.WriteLine($"Test systemów: {i * 10}%");

                for (int j = 0; j < i; j++)
                {
                    Console.Write("==");
                }
                Thread.Sleep(300);
            }

            Silnik.Odpalony = true;
        }
        public void Jedz() => Jedz(50);
        public void Jedz(int dystans)
        {
            if (Silnik.Odpalony)
            {
                double actSpeed = 1;
                int gear = 0;
                for (int i = 0; i < dystans; i++)
                {
                    Console.Clear();
                    actSpeed = i > Silnik.Vmax ? Silnik.Vmax : i;
                    gear = (Int32)Math.Round(actSpeed / Silnik.Vmax * 5 + 1);
                    Console.WriteLine($"Prędkość: {actSpeed} km/h");
                    Console.WriteLine($"Spalanie: {Math.Round(actSpeed / Silnik.Vmax * Silnik.Spalanie, 2)} l/100km");
                    Console.WriteLine($"Bieg: {gear}");
                    Console.WriteLine($"Obroty silnika: {Math.Round(actSpeed / gear * 140)} RPM");
                    Console.WriteLine($"Dystans: {i} km");
                    Console.WriteLine(i % 2 == 0 ? "wrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr" : "wrRrRrRrRrRrRrRrRrRrRrRrRrRrRrR");
                    Thread.Sleep(350);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Silnik nie został uruchomiony");
            }
        }

        public Tir(SilnikSpalinowy silnik)
        {
            Silnik = silnik;
        }
    }

    public abstract class Silnik
    {
        public double Spalanie { get; set; }
        public double Vmax { get; set; }
        public bool Odpalony { get; set; }

        protected Silnik(double spalanie, double vmax)
        {
            Spalanie = spalanie;
            Vmax = vmax;
            Odpalony = false;
        }
    }

    public class SilnikSpalinowy : Silnik
    {
        public SilnikSpalinowy(double spalanie, double vmax) : base(spalanie, vmax) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tir = new Tir(new SilnikSpalinowy(10, 150));

            tir.Odpal();
            tir.Jedz(500);
        }
    }
}