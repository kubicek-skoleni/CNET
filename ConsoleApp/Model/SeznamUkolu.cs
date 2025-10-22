

namespace ConsoleApp.Model
{
    public class SeznamUkolu
    {
        // constructor
        public SeznamUkolu(string soubor)
        {
            //načtení ze souboru
            string[] radky = File.ReadAllLines("ukoly.txt");

            foreach (string radek in radky)
            {
                Ukol novyUkol = new Ukol();
                novyUkol.Popis = radek;
                Ukoly.Add(novyUkol);
            }
        }
        //seznam úkolů
        public List<Ukol> Ukoly = new();

        public void VypisUkoly()
        {
            foreach (var ukol in Ukoly)
            {
                int i = Ukoly.IndexOf(ukol);
                Console.WriteLine($"{i + 1}: {ukol.Zobrazit()}");
            }

            Console.WriteLine();
        }

        public void OznamitSplneni(int cisloUkolu)
        {
            Ukoly[cisloUkolu - 1].Hotovo = true;
        }

        public bool JeHotovo()
        {
            foreach(var ukol in Ukoly)
            {
                if (ukol.Hotovo == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
