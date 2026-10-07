using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Auto
    {
        private int _najeteKilometry; //"field" - na privátní pro třidu,
                                      //pomocný vnitřní stavy a výpočty 

        private string _spz;
        public string SPZ
        {
            get
            {
                return _spz;
            }
            set
            {
                if (value == null)
                {
                    Console.Write("ERROR: SPZ nesmí být prázdá");
                    return;
                }

                if (value.Length > 9)
                {
                    Console.Write("ERROR: SPZ je moc dlouhá");
                    return;
                }
                _spz = value;
            }
        }

        //private string _spz;

        //public string GetSPZ()
        //{
        //    return _spz;
        //}

        //public void SetSPZ(string spz)
        //{
        //    if (spz == null)
        //    {
        //        Console.Write("ERROR: SPZ nesmí být prázdá");
        //        return;
        //    }

        //    if (spz.Length > 9)
        //    {
        //        Console.Write("ERROR: SPZ je moc dlouhá");
        //        return;
        //    }
        //    _spz = spz;
        //}

        public int RokVyroby { get; set; }

        public bool Bourane { get; }

        public string Brand { get; set; }

        public void PridejKilometry(int km)
        {
            _najeteKilometry += km;
        }
    }
}
