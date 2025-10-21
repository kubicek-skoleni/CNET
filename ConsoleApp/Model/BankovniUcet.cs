namespace ConsoleApp.Model
{
    public class BankovniUcet
    {
        public BankovniUcet()
        { }

        public BankovniUcet(string _majitel, string _cisloUctu)
        {
            Majitel = _majitel;
            CisloUctu = _cisloUctu;
            Zustatek = 0;
        }

        public string Majitel;
        public string CisloUctu;
        private decimal Zustatek;

        public void Vloz(decimal castka)
        {
            if(castka <= 0)
            {
                Console.WriteLine("Nelze vložit zápornou nebo nulovou částku.");
                return;
            }
            
            Zustatek += castka;
            Console.WriteLine($"Vloženo: {castka} Kč");
        }

        public void Vyber(decimal castka)
        {
            if(castka > Zustatek)
            {
                Console.WriteLine("Nedostatečný zůstatek na účtu.");
                return;
            }

            Zustatek -= castka;
            Console.WriteLine($"Vybráno: {castka} Kč");
        }

        public void VypisZustatek()
        {
            Console.WriteLine($"Zůstatek na účtu {CisloUctu} majitele {Majitel} je: {Zustatek} Kč");
        }

    }
}
