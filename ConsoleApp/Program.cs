Console.WriteLine("Zadej číslo 1-7 a zmáčkni enter:");

string? line = Console.ReadLine();

int dayNumber = int.Parse(line);

switch (dayNumber)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("pracovní den");
        break;
    case 6:
    case 7:
        Console.WriteLine("víkend");
        break;
    default:
        Console.WriteLine("číslo mimo rozsah!");
        break;
}