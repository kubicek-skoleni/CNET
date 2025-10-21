using ConsoleApp.Model;

var student = new Student();

student.Jmeno = "Jan";
student.Prijmeni = "Novák";
student.Trida = "3.A";
student.RokNarozeni = 2007;

Console.WriteLine($"Student: {student.CeleJmeno()}, Věk: {student.Vek()}");

var student2 = new Student
{
    Jmeno = "Eva",
    Prijmeni = "Svobodová",
    Trida = "2.B",
    RokNarozeni = 2008
};

Console.WriteLine($"Student: {student2.CeleJmeno()}, Věk: {student2.Vek()}");