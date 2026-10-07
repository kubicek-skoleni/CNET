
if (!Directory.Exists(@"C:\tmp\"))
{
    Directory.CreateDirectory(@"C:\tmp\");
}

//File.WriteAllText(@"C:\tmp\poznamka.txt", "Nějaká moje poznámka");
//var poznamka = File.ReadAllText(@"C:\tmp\poznamka.txt");
//Console.WriteLine("zapsal jsem");

//List<string> mesta = [ "Praha", "Brno", "Ostrava" ];
//File.WriteAllLines("mesta.txt", mesta);
//Console.WriteLine("zapsal jsem");

string[] mesta = File.ReadAllLines("mesta.txt");

foreach(var mesto in mesta)
{
    Console.WriteLine(mesto);
}