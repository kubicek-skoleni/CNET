using DataAccess;
using Model;

PeopleDbContext context = new PeopleDbContext();

var addr_count = context.Addresses.Count();
var contract_count = context.Contracts.Count();

Console.WriteLine($"Adres: {addr_count}");
Console.WriteLine($"Smluv: {contract_count}");


























