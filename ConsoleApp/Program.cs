
//  Zadání: načti věk a vypiš, jestli je člověk plnoletý.

Console.WriteLine("zadej věk:");

string input = Console.ReadLine();

int age = int.Parse(input);

if (age >= 18)
    Console.WriteLine("Jste plnoletý/á.");
else
    Console.WriteLine("Nejste plnoletý/á.");