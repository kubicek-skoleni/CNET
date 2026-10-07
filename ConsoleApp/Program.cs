using ConsoleApp;

// uživatel zadává studenty: jméno, příjmení, třída, rok narození
// každý student je jeden řádek v souboru studenti.txt
// po zadání program soubor uloží
// jmeno;prijmeni;trida;rok

//zadej a uloz
StudentiData.ZadejAUlozStudenty("studenti2.txt");

//nacti do kolekce studentu
var students = StudentiData.NactiStudenty("studenti2.txt");
Console.WriteLine($"V kolekci students je {students.Count()} prvků");