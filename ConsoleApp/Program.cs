//for loop
for (int i = 1; i <= 10; i = i + 2)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine("jsem za cyklem");


//while loop
Console.Write("While loop (countdown): ");
int countdown = 5;

while (countdown > 0)
{
    Console.WriteLine($"{countdown} ");
    countdown--;
}
Console.WriteLine("Blast off!");

// kolekce:

List<int> numbers = [2, 5, 6];
List<string> fruits = ["Apple", "Banana", "Orange", "Grape"];
fruits.Add("Mango");

List<string> vegetables = new ();
   vegetables.Add("Carrot");
   vegetables.Add("Broccoli");


//foreach loop
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

fruits.Count();
numbers.Count();

var prvni = fruits[0];

Console.WriteLine($"fruits[0]: {prvni}");

