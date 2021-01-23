using System;

namespace SK055913
{
    class Program
    {
        static void Main(string[] args)
        {
            Boxer boxer = new Boxer(100,100);
            Motocykl motocykl = new Motocykl(boxer);

            motocykl.Jedz();
        }
    }
}
