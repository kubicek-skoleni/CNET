string firstName = "        Alice";
string lastName = "Johnson    ";

//string je immutable - nemění se - vytváří se nový
var upper_alice = firstName.ToUpper();

Console.WriteLine($"fristName: {firstName}");
Console.WriteLine($"upper_alice: {upper_alice}");

string fullName = firstName + " " + lastName;

Console.WriteLine($"Lowercase: {fullName.ToLower()}");

bool statrs_alic = fullName.StartsWith("Alic");

var trimmed = fullName.Trim();

Console.WriteLine($"Trimmed: {trimmed}");

bool contains_john = fullName.Contains("John");