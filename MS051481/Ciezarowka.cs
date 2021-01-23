using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    /// <summary>
    /// Przykład implementacji IPojazd
    /// </summary>
    public class Ciezarowka : IPojazd
    {
        /// <summary>
        /// Ta właściwość powinna mieć typ Silnik
        /// </summary>
        public Silnik Silnik { get; private set; }

        /// <summary>
        /// Tą metodę można zaimplementować dowolnie. Nie musi korzystać z wyrażenia - może to być zwykły blok.
        /// </summary>
        public void Jedz() => Jedz(100);

        /// <summary>
        /// Tą metodę można zaimplementować dowolnie
        /// </summary>
        /// <param name="dystans">Dystans do przejechania. Przy wywołaniu zostanie użyta wartość 100.</param>
        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                Silnik.Dzialaj();
            }
        }

        /// <summary>
        /// Pamiętaj o dodaniu konstruktora.
        /// </summary>
        /// <param name="silnik">Twoja implementacja klasy Silnik</param>
        public Ciezarowka(SilnikDiesla silnik)
        {
            Silnik = silnik;
        }
    }
}
