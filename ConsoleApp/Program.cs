
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

    result.Pred = "text pred";
    result.Za = "za";
    result.Errors = 0;

    return result;
}

var vysledek = Hledej2("xxxxx");
