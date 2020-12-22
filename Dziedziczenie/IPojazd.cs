using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    /// <summary>
    /// Interfejs który należy zaimplementować
    /// </summary>
    public interface IPojazd
    {
        void Jedz();
        void Jedz(int dystans);
    }
}
