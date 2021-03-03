using System;
using System.Linq;

namespace Prezentacja
{
    class Program
    {
        static void Main(string[] args)
        {
            var pojazdy = Helper.Zaladuj();
            Console.Clear();
            Console.WriteLine($"Ilość pojazdów: {pojazdy.Count()}");
            Console.WriteLine("Wciskaj ENTER by uruchomić kolejne pojazdy...");
            Console.ReadLine();

            foreach (var pojazd in pojazdy)
            {
                try
                {
                    Console.WriteLine(pojazd);
                    pojazd.Jedz(100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Console.ResetColor();
                Console.WriteLine("-----------------------");
                Console.ReadLine();
            }
        }
    }
}
