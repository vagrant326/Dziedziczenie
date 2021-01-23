using Dziedziczenie;

namespace DK055906
{
    public class SilnikSpalinowy : Silnik
    {
        static public int Vmax { get; set; }
        public SilnikSpalinowy(int moc, double spalanie, int vmax) : base(moc, spalanie, "wrrr")
        {
            Vmax = vmax;
        }
    }
}