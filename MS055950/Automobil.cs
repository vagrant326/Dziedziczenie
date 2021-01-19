using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;
using System.Threading;

namespace MS055950
{
    class Automobil : IPojazd
    {
        public Silnik Silnik { get; set; }

        private string[] Pojazd { get; set; }
        public void Jedz()
        {
            this.Jedz(10);
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Thread.Sleep(2000);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public void Jedz(int dystans)
        {
            char[] dym = new char[] { 'o', 'O'};
            int k = 0;
            dystans *= 10;
            for (int i = 0; i <= dystans; i++)
            {
                for (int j = 0; j < Pojazd.Length; j++)
                {
                    if (j == Pojazd.Length - 1)
                    {
                        if (k >= dym.Length)
                        {
                            k = 0;
                        }
                        Console.Write(new string(dym[k], i));
                        Console.WriteLine(Pojazd[j]);
                        k++;
                    }
                    else
                    {
                        Console.Write(new string(' ', i));
                        Console.WriteLine(Pojazd[j]);
                    }

                }
                if (!(i == dystans))
                {
                    for (int p = Pojazd.Length - 1; p >= 0; p--)
                    {
                        Console.SetCursorPosition(p, Console.CursorTop - 1);                        
                    }
                    Thread.Sleep(100);
                }
            }

        }
        public Automobil(V8 silnik)
        {
            Silnik = silnik;
            Pojazd = new string[3];
            Pojazd[0] = "   _____    ";
            Pojazd[1] = " _/[] []\\_ ";
            Pojazd[2] = " -O-----O-- ";
        }
    }
}
