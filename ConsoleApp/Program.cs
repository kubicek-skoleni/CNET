using Microsoft.VisualBasic;

Console.WriteLine("Zadej číslo 1-7 a zmáčkni enter:");

string? line = Console.ReadLine();

int dayNumber = int.Parse(line);

//switch expression
string denVTydnu = dayNumber switch
{
    1 => "Pondělí",
    2 => "Úterý",
    3 => "Středa",
    4 => "Čtvrtek",
    5 => "Pátek",
    6 => "Sobota",
    7 => "Neděle",
    _ => "Neplatný den"
};

Console.WriteLine($"den v tydnu je: {denVTydnu}");

//switch expression s podmínkami - pattern matching
string jePracovniDen = dayNumber switch
{
    int i when i >= 1 && i <= 5 => "Pracovní den",
    int i when i >= 6 && i <= 7 => "Víkend",
    _ => "Neplatný den"
};

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