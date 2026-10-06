// počítač si myslí číslo od 1 do 100
// Hráč hádá, program odpovídá „víc“ nebo „míň“.
// Na konci vypíše počet pokusů.

int tajne = Random.Shared.Next(1, 101);
int pokusy = 0;
int tip = 0;

Console.WriteLine("Myslím si číslo od 1 do 100. Hádej!");

while (tip != tajne)
{
    Console.Write("Tvůj tip: ");
    tip = int.Parse(Console.ReadLine());
    
    if(tip < tajne)
            Console.WriteLine("Víc!");
    
    if (tip > tajne)
            Console.WriteLine("Míň!");
    
    pokusy++;
}

Console.WriteLine($"Trefa! Uhodl jsi na {pokusy}. pokus.");
