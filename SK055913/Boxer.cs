﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Dziedziczenie;

namespace SK055913
{
     class Boxer : Silnik
    {

        public Boxer(int moc, double spalanie) : base(moc, spalanie, " | Wrr | ")
        {

        }

        public void Uruchom()
        {
            for(int i= 1; i<20;i++)
            {
                Console.Beep(i + Moc + ((int)Spalanie/i), Moc + (i*10));
            }
          
        }
    }
}
