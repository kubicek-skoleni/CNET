using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal static class StudentiData
    {
        //staticka metoda na nacteni studentu ze souboru
        public static List<Student> NactiStudenty(string soubor)
        {
            string[] nacteno = File.ReadAllLines(soubor);

            List<Student> students = new();

            foreach (var radek in nacteno)
            {
                Console.WriteLine(radek);

                string[] prvky = radek.Split(";");
                var stud_jmeno = prvky[0];
                var stud_prijmeni = prvky[1];
                var stud_trida = prvky[2];
                var stud_rok = prvky[3];

                Student stud = new();
                stud.Jmeno = stud_jmeno;
                stud.Prijmeni = stud_prijmeni;
                stud.Trida = stud_trida;

                int rok;
                bool success = int.TryParse(stud_rok, out rok);
                if (success)
                {
                    stud.RokNarozeni = int.Parse(stud_rok);
                    students.Add(stud);
                }
                else
                {
                    Console.WriteLine($"Přeskakuji studenta, neplatný rok: {stud_rok}");
                }
            }

            return students;
        }

        //staticka metoda na zadani v konzoli a ulozeni studentu do souboru
        public static void ZadejAUlozStudenty(string soubor)
        {
            List<string> radky = new();

            Console.Write("Jméno (prázdné = konec): ");
            string jmeno = Console.ReadLine();

            while (!string.IsNullOrEmpty(jmeno)) //signál že končí zadávání je prázdné jméno
            {
                Console.WriteLine("Zadej příjmení:");
                var prijmeni = Console.ReadLine();
                Console.WriteLine("Zadej třídu:");
                var trida = Console.ReadLine();
                Console.WriteLine("Zadej rok narození:");
                int rok;
                while (!int.TryParse(Console.ReadLine(), out rok))
                {
                    Console.Write("To není číslo. Rok narození: ");
                }

                var radek = $"{jmeno};{prijmeni};{trida};{rok}";
                radky.Add(radek);

                Console.Write("Jméno (prázdné = konec): ");
                jmeno = Console.ReadLine();
            }

            if (radky.Count() > 0)
            {
                File.WriteAllLines(soubor, radky);
                Console.WriteLine($"Uložil jsem {radky.Count()} do {soubor}");
            }
            else
            {
                Console.WriteLine("prázdná kolekce, neukládám");
            }
        }
    }
}
