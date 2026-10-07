// uživatel zadává studenty: jméno, příjmení, třída, rok narození
// každý student je jeden řádek v souboru studenti.txt
// po zadání program soubor uloží
// jmeno;prijmeni;trida;rok


//while zadání - prázdný řádek ukončení zadávání

List<string> radky = new();

Console.Write("Jméno (prázdné = konec): ");
string jmeno = Console.ReadLine();

while(!string.IsNullOrEmpty(jmeno)) //signál že končí zadávání je prázdné jméno
{
    Console.WriteLine("Zadej příjmení:");
    var prijmeni = Console.ReadLine();
    Console.WriteLine("Zadej třídu:");
    var trida = Console.ReadLine();
    Console.WriteLine("Zadej rok narození:");
    var rok = Console.ReadLine();

    var radek = $"{jmeno};{prijmeni};{trida};{rok}";
    radky.Add(radek);

    Console.Write("Jméno (prázdné = konec): ");
    jmeno = Console.ReadLine();
}

if (radky.Count() > 0)
{
    File.WriteAllLines("studenti.txt", radky);
    Console.WriteLine($"Uložil jsem {radky.Count()} do studenti.txt");
}
else
{
    Console.WriteLine("prázdná kolekce, neukládám");
}

var nacteno = File.ReadAllLines("studenti.txt");

foreach(var radek in nacteno)
{
    Console.WriteLine(radek);
}