using Dziedziczenie;

namespace PM055928
{
    public class Silnik_BMW_V8 : Silnik
    {
        public int pojemnosc;

        public Silnik_BMW_V8(int moc, int pojemnosc, double spalanie, string dzwiek) : base(moc, spalanie, dzwiek)
        {
            this.pojemnosc = pojemnosc;
        }
    }
}