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

        public void Jedz() => Jedz(100);

        public void Jedz(int dystans)
        {
            Console.WriteLine(
@"
   %%%%   %%%%%%%     %%        %%%%%%      %%%%%%%
 %     %     %       %  %       %     %        %                    
   %         %      %    %      %     %        %
      %      %     %%%%%%%%     %%%%%%         %
  %     %    %    %        %    %     %        %
   %%%%      $   %          %   %       %      %
");
            if (dystans > 117)
                dystans = 117;

            Console.ForegroundColor = ConsoleColor.Blue;
            string trasaJedynka = new string(' ', dystans + 2);
            string trasaDwojka = new string(' ', dystans + 2);

            char[] trasaTab1 = trasaJedynka.ToCharArray();
            char[] trasaTab2 = trasaDwojka.ToCharArray();

            Random rnd = new Random();
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

                Console.WriteLine(trasaTab1);
                Console.WriteLine(trasaTab2);
                Console.WriteLine($"Prędkość {rnd.Next() %10 +50} km/h" );
                Console.WriteLine($"Spalanie {rnd.Next()%3.5+5.3} l/100km");
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 4);
                Thread.Sleep(50);// tak nie wolno
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Silnik.Dzialaj();
            Console.WriteLine("I pojechał.");

            Console.ForegroundColor = ConsoleColor.White;
        }



    }
}
