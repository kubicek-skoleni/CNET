using ConsoleApp.Model;

List<Student> students = new()
{
    new Student("Alice", 2000),
    new Student("Bob", 2004),
    new Student("Charlie", 2008),
    new Student("Diana", 2010),
    new Student("Eve", 2015),
    new Student("Frank", 1995)
};

var studenti_nad_18 = students
                    .Where(stud => stud.Vek() >= 18);

foreach (var stud in studenti_nad_18)
{
    Console.WriteLine($"{stud.Jmeno} {stud.Vek()}");
}

