using ConsoleApp;

Console.WriteLine("školní systém");


Student student1 = new();

var delka = student1.Jmeno;

student1 = new();

Console.WriteLine(student1.Jmeno);


student1.Jmeno = "Pavel";
student1.Prijmeni = "Novák";
student1.RokNarozeni = 2000;
student1.Trida = "B";
student1.Adresa = "Dolní 52, Praha";


//Console.WriteLine($"jméno: {student1.Jmeno}");
//// ************************
//var vek1 = student1.Vek();
//// ************************
//Console.WriteLine($"{student1.CeleJmeno()} má {student1.Vek()}");

////inicializator
//Student student2 = new()
//{
//    Jmeno = "Eva",
//    Prijmeni = "Svobodová",
//    Trida = "2.B",
//    RokNarozeni = 2008
//};
//Console.WriteLine($"{student2.CeleJmeno()} má {student2.Vek()}");


