
// Metoda je pojmenovaný kus kódu, který jde zavolat opakovaně.


int[] teploty_celsius = [-10, 0, 15, 20, 25, 30, 35];

foreach(int teplota_c in teploty_celsius)
{
    double teplota_f = FromCelsiusToFahrenheit(teplota_c);
    Console.WriteLine($"{teplota_c} °C = {teplota_f} °F");
}

double FromCelsiusToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9 / 5) + 32;
    return fahrenheit;
}