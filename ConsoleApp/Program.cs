﻿using ConsoleApp.Model;

SeznamUkolu seznamUkolu = new SeznamUkolu("ukoly.txt");

if(seznamUkolu.PodariloSeNacist == false)
{
    Console.WriteLine("Konec programu. Nepodařilo se načíst úkoly.");
    return;
}

seznamUkolu.VypisUkoly();

Console.WriteLine("zadej číslo splněného úkolu nebo Q pro konec programu:");
var vstup = Console.ReadLine();


while (vstup != "Q")
{
    int cisloSplneny = int.Parse(vstup);
    seznamUkolu.OznamitSplneni(cisloSplneny);

    seznamUkolu.VypisUkoly();

    if (seznamUkolu.JeHotovo())
    {
        Console.WriteLine("Všechny úkoly jsou hotové! Hurá!");
        break;
    }

    Console.WriteLine("zadej číslo splněného úkolu nebo Q pro konec programu:");
    vstup = Console.ReadLine();
}

Console.WriteLine("ukončení programu");

















