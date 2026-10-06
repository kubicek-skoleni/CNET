

using ConsoleApp;

Kostka kostka_6 = new(6);

Kostka kostka_20 = new(20);



for (int i = 1; i <= 10; i++)
{
    int hod_6 = kostka_6.Hod();
    int hod_20 = kostka_20.Hod();
    Console.WriteLine($"Hod {i}: {hod_6}, {hod_20}");
}