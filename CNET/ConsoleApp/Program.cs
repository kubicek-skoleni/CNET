
using DataAccess;
using Model;

PeopleDbContext context = new ();

var p_count = context.Persons.Count();

Console.WriteLine($"V databázi je {p_count} osob.");

if (p_count == 0)
{
    Person person = new()
    {
        FirstName = "Jan",
        LastName = "Novák",
        DateOfBirth = new DateTime(1980, 5, 12),
        Email = "jan@novak.com"
    };

    context.Persons.Add(person);
    int ulozeno = context.SaveChanges();

    if (ulozeno > 0)
    {
        Console.WriteLine("Osoba byla uložena.");
    }
    else
    {
        Console.WriteLine("Osoba uložena nebyla.");
    }
}
























//using System.Text.Json;
//using Model;

//string file = @"data2024.json";

//var file_content = File.ReadAllText(file);

//List<Person> persons = JsonSerializer
//                .Deserialize<List<Person>>(file_content)!;

//Console.WriteLine($"Načetl jsem {persons.Count} osob.");


