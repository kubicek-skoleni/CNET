// See https://aka.ms/new-console-template for more information
using ConsoleApp;

Console.WriteLine("Hello, World!");


string[] words = { "apple", "banana", "cherry" };

var stud = new Student()
{
    Name = "John Doe",
    //Age = 20
};

stud.Name = "  ";

List<int> numbers = [ 10, 50, -22 ];



int tempInFahrenheit = 45;

//pattern matching + switch expression
var textInfo = tempInFahrenheit switch
    {
        < 32 => "solid",
        32 => "solid/liquid transition",
        (> 32) and (< 212) => "liquid",
        212 => "liquid / gas transition",
        _ => "unknown"
    };


string message = words[3];


string xx = stud._name;




