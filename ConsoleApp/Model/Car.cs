using System;

namespace ConsoleApp.Model
{
    public class Auto
    {
        // konstruktor třídy Auto - vytvoření nového
        public Auto(string spz) 
        { 
            SPZ = spz;
        }

        public Auto(string spz, string znacka)
        {
            SPZ = spz;
            Znacka = znacka;
        }

        // vlastnosti (properties) auta
        public string SPZ;
        int UjeteKilometry;
        public DateTime DatumPosledniUdrzby;
        public string Znacka;
        public string Barva;


        // metody - manipulace s autem
        public void PridejKilometry(int kilometry)
        {
            if (kilometry > 0)
            {
                UjeteKilometry += kilometry;
            }
            else
            {
                Console.WriteLine("Pozor pokus o snížení najetých km");
            }
        }

        public void VypisInfo()
        {
            Console.WriteLine($"SPZ: {SPZ}, Ujeté kilometry: {UjeteKilometry}, Datum poslední údržby: {DatumPosledniUdrzby}, Značka: {Znacka}, Barva: {Barva}");
        }
    }
}
