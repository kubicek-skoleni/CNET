// Metoda zjistí, jestli je celé číslo sudé.

//int JeSude(int cislo)

// Metoda spočítá obsah obdélníku ze dvou stran.

//double Obsah(double a, double b)

// Metoda zopakuje text zadaný počet krát a
// výsledek vrátí jako jeden řetězec.

string Opakuj(int pocetOpakovani, string text)
{
    string vysledek = "";

    for(int i = 0; i < pocetOpakovani; i++)
    {
        vysledek += text;
    }

    return vysledek;
}

Console.WriteLine("Zadej text, který chceš opakovat");
var text = Console.ReadLine();
Console.WriteLine("Zadej kolikrát: ");
var opakovani = int.Parse(Console.ReadLine());
var vysledek = Opakuj(opakovani, text);
Console.WriteLine(vysledek);

