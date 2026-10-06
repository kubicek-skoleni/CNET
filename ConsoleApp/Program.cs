int a = 7;
int b = 2;

// aritmetické
Console.WriteLine(a + b);        // 9
Console.WriteLine(a - b);        // 5
Console.WriteLine(a * b);        // 14
Console.WriteLine(a / b);        // 3   celočíselné dělení, zbytek se zahodí
Console.WriteLine(a % b);        // 1   zbytek po dělení
Console.WriteLine(a / 2.0);      // 3,5 jedna strana je double, dělí se desetinně

// zkrácené přiřazení
a += 3;                          // a = a + 3;  → 10
a -= 1;                          // 9
a *= 2;                          // 18
a++;                             // 19
a--;                             // 18

int c = 7;
int vysledek = (c > 5) ? 1 : 2;

if (c > 5)
{
    vysledek = 1;
}
else
{
    vysledek = 2;
}