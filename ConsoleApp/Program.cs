
// Random.Shared.Next(1, 10);
// AND: &&
// OR: ||
// ==
//int a = 10;
//if (a > 0 && a <= 5)
//    Console.WriteLine("Zadal jsi číslo mezi 1 a 5");
//else
//    Console.WriteLine("Zadal jsi číslo mimo rozsah 1-5");

//if (a == 105)
//    Console.WriteLine("a je 105");

// *****************************************************
// hráč zadá písmeno k, n nebo p. (kámen, nůžky, papír)
// Počítač si náhodně vybere.
// Program vypíše obě volby a kdo vyhrál.
// *****************************************************

// 1. načíst vstup od hráče
Console.WriteLine("Zadej svou volbu (k - kámen, n - nůžky, p - papír):");
string hrac = Console.ReadLine().Trim().ToLower();

if(hrac != "k" && hrac != "n" && hrac != "p")
{
    Console.WriteLine("Neplatná volba. Zadej k, n nebo p.");
    return;
}

// 2. náhodně vybrat volbu počítače
int hod = Random.Shared.Next(1, 4);
string pocitac = hod switch
{
    1 => "k",
    2 => "n",
    3 => "p"
};

// 3. porovnat volby a vypsat výsledek
Console.WriteLine($"hráč zvolil: {hrac}, počítač zvolil: {pocitac}");

if (hrac == pocitac)
{
    Console.WriteLine("remíza");
} 
else if(     (hrac == "k" && pocitac == "n") 
          || (hrac == "n" && pocitac == "p")
          || (hrac == "p" && pocitac == "k")
        )
 
{
    Console.WriteLine("vyhrál hráč");
}
else
{
    Console.WriteLine("vyhrál počítač");
}