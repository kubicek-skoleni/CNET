using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Auto
    {
        private int _najeteKilometry;

        public string SPZ;

        public int RokVyroby;

        public bool Bourane;

        public string Brand;

        public void PridejKilometry(int km)
        {
            _najeteKilometry += km;
        }
    }
}
