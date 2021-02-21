using Dziedziczenie;

namespace TK056638
{
    public enum Voltage
    {
        LowVoltage,
        HighVoltage
    }
    
    public class TeslaSilnik : Silnik
    {
        public double HorsePower { get; set; }
        public Voltage Voltage { get; set; }

        public TeslaSilnik(int moc, double spalanie, string dzwiek, double horsePower, Voltage voltage) : base(moc, spalanie, dzwiek)
        {
            HorsePower = horsePower;
            Voltage = voltage;
        }
    }
}