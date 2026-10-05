var random = Random.Shared.Next(1, 10);

// hráč zadá písmeno k, n nebo p.
// Počítač si náhodně vybere.
// Program vypíše obě volby a kdo vyhrál.


// AND: &&
// OR: ||
// ==
int a = 10;
if (a > 0 && a <= 5)
    Console.WriteLine("Zadal jsi číslo mezi 1 a 5");
else
    Console.WriteLine("Zadal jsi číslo mimo rozsah 1-5");

if (a == 105)
    Console.WriteLine("a je 105");