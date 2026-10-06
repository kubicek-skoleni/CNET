// auto (car)

// SPZ, rok vyroby, jestli bylo bourané, značka (brand)

using ConsoleApp;

Auto skodovka = new()
{
    SPZ = "ABX123",
    Bourane = false,
    Brand = "škoda",
    RokVyroby = 2023
};

Console.WriteLine(skodovka.Brand + " " + skodovka.SPZ);