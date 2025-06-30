using System;
using 

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int vyber = rnd.Next(1, 3);
            for (int i = 0; i < 8; i++)
            {
                if (vyber == 1)
                {
                    SpecZnak();
                }
                if (vyber == 2)
                {
                    Cislo();
                }
                if (vyber == 3)
                {
                    Pismeno();
                }
            }
        }

        private static void Pismeno()
        {
            throw new NotImplementedException();
        }

        private static void Cislo()
        {
            throw new NotImplementedException();
        }

        private static void SpecZnak()
        {
            throw new NotImplementedException();
        }
    }
}