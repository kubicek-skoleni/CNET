

Console.WriteLine("Zadej číslo nebo 'Q' pro ukončení:");

int sum = 0;
string line = Console.ReadLine();

while(line != "Q")
{
    int number = int.Parse(line);
    sum += number;

    Console.WriteLine($"Aktuální suma je: {sum}");
    Console.WriteLine("Zadej číslo nebo 'Q' pro ukončení:");
    line = Console.ReadLine();
}

Console.WriteLine($"Konec programu, dosažená suma: {sum}");