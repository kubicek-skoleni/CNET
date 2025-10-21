int dayNumber = 3;

//switch expression
string denVTydnu = dayNumber switch
{
    1 => "Pondělí",
    2 => "Úterý",
    3 => "Středa",
    4 => "Čtvrtek",
    5 => "Pátek",
    6 => "Sobota",
    7 => "Neděle",
    _ => "Neplatný den"
};