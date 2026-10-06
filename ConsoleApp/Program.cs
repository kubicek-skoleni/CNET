// Adresa: ulice, číslo popisné, město, PSČ a stát.
// Metoda "NaJedenRadek()" vrátí (string) adresu na jednom řádku.

using ConsoleApp;

Adresa adr = new()
{
    Ulice = "Hořejší",
    CisloPopisne = 33,
    Mesto = "Plzeň",
    PSC = "30500",
    Stat = "CZ",
};

Console.WriteLine(adr.NaJedenRadek());