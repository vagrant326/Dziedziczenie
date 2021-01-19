using System;
using System.Threading;

namespace MZ048257
{
    class Program
    {
        static void Main(string[] args)
        {

            Car audi = new Car(new DieselSOHC(130, 5.5, "No zarycz! No!"));
            audi.Jedz();

        }
    }
}
