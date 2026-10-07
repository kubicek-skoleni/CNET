
// tuple - ad hoc združení více hodnot
using ConsoleApp;

(string pred, string za, int error) Hledej(string input)
{
    string textPred = "pred";
    string textZa = "za";

    return (textPred, textZa, 0);
}

var result = Hledej("můj text");


VysledekHledani Hledej2(string input)
{
    VysledekHledani result = new();

    result.TextPred = "text pred";
    result.TextZa = "za";
    result.Errors = 0;

    return result;
}

var vysledek = Hledej2("xxxxx");

Kostka kostka = new(5);

int x = 5;

var pokus = $"{kostka}";

Console.WriteLine(kostka);