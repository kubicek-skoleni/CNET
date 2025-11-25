int[] numbers = { 10, 23, 5, 8, 15, 42, 7 };

var suda = numbers.Where(cislo => cislo % 2 == 0);

var ordered = numbers.OrderByDescending(cislo => cislo);

var avg = numbers.Average();
//Console.WriteLine($"Avg: {Math.Round(avg,1)}");

var cnt = numbers.Count();
//Console.WriteLine($"Count: {cnt}");

var take3 = numbers.Take(3);

var skip3 = numbers.Skip(3);

//Select
var doubles = numbers.Select(cislo => cislo * 2);


//First
int first = numbers.First();

var result = numbers
    .Where(cislo => cislo > 15)
    .OrderByDescending(x => x)
    .Select(x => x + 100);

foreach (var num in result)
{
    Console.WriteLine(num);
}




















//using DataAccess;
//using Model;

//PeopleDbContext context = new PeopleDbContext();

//var addr_count = context.Addresses.Count();
//var contract_count = context.Contracts.Count();

//Console.WriteLine($"Adres: {addr_count}");
//Console.WriteLine($"Smluv: {contract_count}");






























