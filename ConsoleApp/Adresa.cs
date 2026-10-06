using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Adresa
    {
        // Adresa: ulice, číslo popisné, město, PSČ a stát.
        // Metoda "NaJedenRadek()" vrátí (string) adresu na jednom řádku.

        public string Ulice;

        public int CisloPopisne;

        public string Mesto;

        public string PSC;

        public string Stat;

        public string NaJedenRadek()
        {
            return $"{Ulice} {CisloPopisne}, {Mesto} {PSC}, {Stat}";
        }

    }
}
