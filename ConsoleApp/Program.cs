
// Metoda na výpočet věku z roku narození

// navratovy_typ Jmeno(typ param1, typ param2) { return hodnota; }

int Age(int rokNarozeni)
{
    var aktualniRok = DateTime.Now.Year;
    int vek = aktualniRok - rokNarozeni;
    return vek;
}

// metoda která vrátí celé jméno z firstName + lastName => FullName

string FullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}
