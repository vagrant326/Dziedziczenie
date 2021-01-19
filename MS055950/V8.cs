using System;
using Dziedziczenie;

namespace MS055950
{
    public class V8 : Silnik
    {
        public V8(int moc, double spalanie) : base(moc, spalanie, "brum ")
        {

        }
        public new void Dzialaj()
        {
            Console.WriteLine(Dzwiek);
        }
    }
}
