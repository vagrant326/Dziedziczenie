using System;
using System.Collections.Generic;
using System.Text;

namespace MK055917
{
    public class Tir : Dziedziczenie.IPojazd
    {
        public Dziedziczenie.Silnik Silnik { get; set; }

        public void Odpal()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("===== Uruchamianie silnika =====\n");
                Console.WriteLine($"Prędkość maksymalna: {Silnik.Moc}");
                Console.WriteLine($"Spalanie: {Silnik.Spalanie}\n");
                Console.WriteLine($"Test systemów: {i * 10}%");

                for (int j = 0; j < i; j++)
                {
                    Console.Write("==");
                }
                Thread.Sleep(300);
                Console.SetCursorPosition(0, Console.CursorTop - 6);
            }
        }
        public void Jedz() => Jedz(50);
        public void Jedz(int dystans)
        {
            double actSpeed = 1;
            int gear = 0;
            for (int i = 0; i < dystans; i++)
            {
                actSpeed = i > Silnik.Moc ? Silnik.Moc : i;
                gear = (Int32)Math.Round(actSpeed / Silnik.Moc * 5 + 1);
                Console.WriteLine($"Prędkość: {actSpeed} km/h                              ");
                Console.WriteLine($"Spalanie: {Math.Round(actSpeed / Silnik.Moc * Silnik.Spalanie, 2)} l/100km               ");
                Console.WriteLine($"Bieg: {gear}                              ");
                Console.WriteLine($"Obroty silnika: {Math.Round(actSpeed / gear * 140)} RPM               ");
                Console.WriteLine($"Dystans: {i} km               ");
                Console.WriteLine(i % 2 == 0 ? "wrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr" : "wrRrRrRrRrRrRrRrRrRrRrRrRrRrRrR               ");
                Thread.Sleep(350);
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 6);
            }
        }

        public Tir(SilnikSpalinowy silnik)
        {
            Silnik = silnik;
        }
    }

}
