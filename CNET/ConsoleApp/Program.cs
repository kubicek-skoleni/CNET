using System.Text.Json;
using Model;

string file = @"data2024.json";

var file_content = File.ReadAllText(file);

List<Person> persons = JsonSerializer
                .Deserialize<List<Person>>(file_content)!;

Console.WriteLine($"Načetl jsem {persons.Count} osob.");