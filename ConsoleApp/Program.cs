// uživatel zadá věk
// vypište zda je uživatel plnoletý nebo ne

Console.WriteLine("zadej věk:");

string input = Console.ReadLine();

int age = int.Parse(input);

if(age >= 18)
    Console.WriteLine("Jste plnoletý/á.");
else
    Console.WriteLine("Nejste plnoletý/á.");
