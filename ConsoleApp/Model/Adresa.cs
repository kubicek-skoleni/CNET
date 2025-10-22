using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    public class Adresa
    {
        public string Ulice;
        public string Mesto;
        public string PSC;
        public string Stat;
        public string CelaAdresy()
        {
            return $"{Ulice}, {Mesto}, {PSC}, {Stat}";
        }
    }
}
