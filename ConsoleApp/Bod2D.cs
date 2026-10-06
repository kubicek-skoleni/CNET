using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Bod2D
    {
        public double X;
        public double Y;

        public double VzdalenostOdPocatku()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
