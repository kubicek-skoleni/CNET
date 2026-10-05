// program se zeptá na jméno a firmu.
// Pak vytiskne jmenovku v rámečku z hvězdiček.
// Jméno bude velkými písmeny.

/*
******************************
* JAN NOVÁK                  *
* Firma s.r.o.               *
******************************

*/

Console.Write("Jméno: ");
string jmeno = Console.ReadLine();

Console.Write("Firma: ");
string firma = Console.ReadLine();

string hvezdicky = "******************************";
int sirka = hvezdicky.Length;

Console.WriteLine(hvezdicky);
Console.WriteLine($"* {jmeno.ToUpper().PadRight(sirka -4) } *");
Console.WriteLine($"* {firma.PadRight(sirka - 4)} *");
Console.WriteLine(hvezdicky);