﻿using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace MZ048257
{
    public class DieselSOHC : Silnik
    {
        public DieselSOHC(int moc, double spalanie, string dzwiek) : base(moc, spalanie, dzwiek)
        {

        }

        new public void Dzialaj()
        {
            Console.Write($"{Dzwiek}  tuk-tuk-tuk.........");
        }
    }
}
