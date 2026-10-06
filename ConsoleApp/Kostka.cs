using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Kostka
    {
        public Kostka(int pocetSten)
        {
            _pocetSten = pocetSten;
        }

        private int _pocetSten;

        public int Hod()
        {
            return Random.Shared.Next(1, _pocetSten + 1);
        }
    }
}
