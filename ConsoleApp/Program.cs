
var result = FromCelsiusToFahrenheit(10.5);

Console.WriteLine($"10.5 C = {result} F");

double FromCelsiusToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9 / 5) + 32;

    return fahrenheit;
}