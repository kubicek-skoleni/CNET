using DataAccess;
using Microsoft.EntityFrameworkCore;

PeopleDbContext context = new PeopleDbContext();

var lide = context.Persons
                .Include(x => x.Address)
                .Where(x => x.Address != null)
                .Where(x => x.Address.City == "Lanškroun")
                ;
//Console.WriteLine($"Lidé v Lanškrouně:");
//foreach (var person in lide)
//{
//    Console.WriteLine($"{person.FirstName} {person.LastName} {person.Address.City} {person.Address.Street}");
//}

// 10 osob s nejvíce smlouvami
var lide2 = context.Persons
                .Include(x => x.Contracts)
                .OrderByDescending(x => x.Contracts.Count)
                .Take(10)
                ;
//Console.WriteLine($"10 osob s nejvíce smlouvami:");
//foreach (var person in lide2)
//{
//    Console.WriteLine($"{person.FirstName} {person.LastName} - počet smluv: {person.Contracts.Count}");
//}

// kolik měst
var cities_count = context.Addresses
    .Select(x => x.City)
    .Distinct()
    .Count();

Console.WriteLine($"počet měst: {cities_count}");

var lide_mesta =
    context.Persons
    .Include(x => x.Address)
    .Where(x => x.Address != null)
    .GroupBy(x => x.Address!.City)
    .Select(x => new
    {
        City = x.Key,
        Count = x.Count()
    })
    .OrderByDescending(x => x.Count)
    .Take(10);

foreach (var item in lide_mesta)
{
    Console.WriteLine($"{item.City}: {item.Count}");
}
