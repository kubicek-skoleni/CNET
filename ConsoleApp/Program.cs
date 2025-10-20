﻿// den v týdnu pomocí switch
// 1-7 = pondělí - neděle
// pokud je číslo mimo tento rozsah, vypiš "Neplatný den"

Console.WriteLine("Zadej číslo 1-7 a zmáčkni enter:");

string? line = Console.ReadLine();

int dayNumber = int.Parse(line);

//classic switch statement
switch (dayNumber)
{
    case 1:
        Console.WriteLine("Pondělí");
        break;
    case 2:
        Console.WriteLine("Úterý");
        break;
    case 3:
        Console.WriteLine("Středa");
        break;
    case 4:
        Console.WriteLine("Čtvrtek");
        break;
    case 5:
        Console.WriteLine("Pátek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Neděle");
        break;
    default:
        Console.WriteLine("číslo mimo rozsah!");
        break;
}

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