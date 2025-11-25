using System.Text.Json;
using DataAccess;
using Model;

PeopleDbContext context = new ();

string file = @"data2024.json";

var file_content = File.ReadAllText(file);

List<Person> persons = JsonSerializer
                .Deserialize<List<Person>>(file_content)!;

Console.WriteLine($"Načetl jsem {persons.Count} osob.");

if (context.Persons.Count() > 1000)
{
    Console.WriteLine("DB již obsahuje více než 1000 osob");
    return;
}
else
{
    context.Persons.AddRange(persons);
    context.SaveChanges();
}

  
























