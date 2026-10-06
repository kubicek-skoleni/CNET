
// udělejte metodu která dostane na vstup dvě čísla (int)
// a vrátí větší z nich

int a = 10;
int b = 11;

int v = Vetsi(a, b);
Console.WriteLine($"větši z {a} a {b} je {v}");

int Vetsi(int cislo1, int cislo2)
{
    if (cislo1 < cislo2)
        return cislo2;
    else
        return cislo1;
}