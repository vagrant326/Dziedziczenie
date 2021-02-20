using System;
using Dziedziczenie;

namespace PM055928
{
    public class BMW_M2 : IPojazd
    {
        private int prędkośćMax = 280;
        public Silnik_BMW_V8 Silnik { get; set; }
        private int dystans;

        public void Jedz() // Prędkość maks 280  km/h
        {
            double dystans = 4.6;
            var date1 = DateTime.Now;
            Console.WriteLine("Wyruszyłeś o godzinie: {0:h:mm:ss}", date1);
            Console.WriteLine("Jeśli chcesz się zatrzymać kliklij przycisk");
            var z = Console.ReadLine();
            if (z.Length > 0)
            {
                var date2 = DateTime.Now;
                var date3 = date2 - date1;
                var sec = date3.TotalSeconds;
                var suma = dystans * sec;


                Console.WriteLine("Jechałeś: {0:F1} sekund", sec);
                Console.WriteLine("Przejechałeś: {0:F1} KM z prędkością 280 KM/h", suma);
            }
        }

        public void Jedz(int dystans) //Dystans w metrach
        {
            int sek = 0;
            while (dystans / 13 >= 0)
            {
                sek++;
                dystans -= 13;
            }

            Console.WriteLine("Jak długo pojedziesz w sekundach: {0}", sek);
            Console.WriteLine("Wyruszyłeś o godzinie: {0:h:mm:ss}", DateTime.Now);
            Console.WriteLine("Pokonuje dystans czekaj");
            var pokonanyDys = M(sek);
            if (pokonanyDys == true)
            {
                Console.WriteLine("Dystans pokonany, aktualny czas: {0:h:mm:ss}", DateTime.Now);
            }
            else
            {
                Console.WriteLine("Gdzieś się rozbiłem ");
            }
            
        }

        static bool M(int sec)
        {
            var date1 = DateTime.Now;
            var date2 = date1.AddSeconds(sec);
            var date3 = DateTime.Now;

            for (date3 = DateTime.Now; date3 <= date2;)
            {
                if (date2.Second == date3.Second)
                {
                    //Console.WriteLine("OK");
                    return true;
                }
                date3 = DateTime.Now;
            }
            return false;
        }
    }
}