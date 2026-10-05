var company = "tech corp";
var yearsofexperience = 5;
var hourlyrate = 346.50;
int totalearnings = yearsofexperience * 2000 * (int)hourlyrate;

int a = 10;
byte b = 255;

//b = (byte)a;
b = (byte)hourlyrate;

Console.WriteLine($"b: {b}");

string numberStr = "12345";

int number = int.Parse(numberStr);

number = number + 1;

Console.WriteLine($"number: {number}");

string numberAsString = number.ToString();

string hourlyRateAsString = hourlyrate.ToString();

Console.WriteLine(hourlyRateAsString);

int hourlyRateAsInt = (int)Math.Round(hourlyrate, 0, MidpointRounding.AwayFromZero);

Console.WriteLine($"hourlyRateAsInt: {hourlyRateAsInt}");