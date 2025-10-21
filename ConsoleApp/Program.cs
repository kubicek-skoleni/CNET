using ConsoleApp.Model;

//seznam úkolů
List<Ukol> ukoly = new();

//načtení ze souboru
string[] radky = File.ReadAllLines("ukoly.txt");

// uložení do kolence jako objekty Ukol
foreach (string radek in radky)
{
    Ukol novyUkol = new Ukol();
    novyUkol.Popis = radek;
    ukoly.Add(novyUkol);
}

VypisUkoly(ukoly);

//
Console.WriteLine("zadej číslo splněného úkolu nebo Q pro konec programu:");
var vstup = Console.ReadLine();


while (vstup != "Q")
{
    int cisloSplneny = int.Parse(vstup);
    ukoly[cisloSplneny - 1].Hotovo = true;

    VypisUkoly(ukoly);

    Console.WriteLine("zadej číslo splněného úkolu nebo Q pro konec programu:");
    vstup = Console.ReadLine();
}

//výpis úkolů
void VypisUkoly(List<Ukol> ukoly)
{
    foreach (var ukol in ukoly)
    {
        int i = ukoly.IndexOf(ukol);
        Console.WriteLine($"{i + 1}: {ukol.Zobrazit()}");
    }
}
















