using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    /// <summary>
    /// Przykład implementacji Silnika
    /// </summary>
    public class SilnikDiesla : Silnik
    {
        public SilnikDiesla(int moc, double spalanie) : base(moc, spalanie, "WRRRRRRRRRRRRRUM")
        {

        }
    }
}
