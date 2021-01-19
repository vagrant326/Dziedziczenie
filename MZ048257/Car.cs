using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;
using System.Threading;



namespace MZ048257
{
    class Car : IPojazd
    {
        public Silnik silnik { get; set; }

        public DieselSOHC Silnik { get; private set; }
        public Car(DieselSOHC silnik)
        {
            Silnik = silnik;
        }

        public void Jedz()
        {

            int dystans = 100;
            Console.ForegroundColor = ConsoleColor.Yellow;
            string trasaJedynka = new string(' ', dystans + 2);
            string trasaDwojka = new string(' ', dystans + 2);

            char[] trasaTab1 = trasaJedynka.ToCharArray();
            char[] trasaTab2 = trasaDwojka.ToCharArray();
            for (int i = 0; i < dystans - 7; i++)
            {
                trasaTab1[i + 2] = ' ';
                trasaTab2[i] = ',';
                if (i < dystans - 7)
                {
                    trasaTab1[i + 3] = '#';
                    trasaTab1[i + 4] = '#';
                    trasaTab2[i + 2] = '#';
                    trasaTab2[i + 3] = '#';
                    trasaTab2[i + 4] = '#';
                    trasaTab2[i + 5] = '#';
                    trasaTab2[i + 6] = '#';
                    trasaTab2[i + 7] = '#';
                }

                Console.Clear();
                Console.WriteLine(trasaTab1);
                Console.Write(trasaTab2);
                Thread.Sleep(10);

            }
            Silnik.Dzialaj();
            Console.WriteLine("I pojechał.");
        }

        public void Jedz(int dystans)
        {
            if (dystans > 500)
                dystans = 500;

            Console.ForegroundColor = ConsoleColor.Blue;
            string trasaJedynka = new string(' ', dystans + 2);
            string trasaDwojka = new string(' ', dystans + 2);

            char[] trasaTab1 = trasaJedynka.ToCharArray();
            char[] trasaTab2 = trasaDwojka.ToCharArray();
            for (int i = 0; i < dystans - 7; i++)
            {

                trasaTab1[i + 2] = ' ';
                trasaTab2[i] = ',';
                if (i < dystans - 7)
                {
                    trasaTab1[i + 3] = '#';
                    trasaTab1[i + 4] = '#';
                    trasaTab2[i + 2] = '#';
                    trasaTab2[i + 3] = '#';
                    trasaTab2[i + 4] = '#';
                    trasaTab2[i + 5] = '#';
                    trasaTab2[i + 6] = '#';
                    trasaTab2[i + 7] = '#';
                }

                
                Console.Clear();
                Console.WriteLine(trasaTab1);
                Console.Write(trasaTab2);
                
            }
            Console.WriteLine("I pojechał.");

            Silnik.Dzialaj();

            Console.ForegroundColor = ConsoleColor.White;
        }



    }
}
