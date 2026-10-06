
using ConsoleApp;

Student pavel = new()
{
    Jmeno = "Pavel",
    Prijmeni = "Novák",
    AdresaDoma = new()
    {
        Ulice = "Česká",
        CisloPopisne = 12,
        Mesto = "Brno",
        PSC = "60200"
    }
};



//Adresa pavelDoma = new()
//{
//    Ulice = "Česká",
//    CisloPopisne = 12,
//    Mesto = "Brno",
//    PSC = "60200"
//};
//pavel.AdresaDoma = pavelDoma;

pavel.Vek();

Console.WriteLine($"{pavel}");