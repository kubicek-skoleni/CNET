int[] numbers = { 11, 2, 13, -97542, 44, 
    -5, 6, 127, -99, 0, 256, 0, 12, 11 };

//// 1.  kolik obsahuje pole kladných čísel
//// 2.  kolik obsahuje pole záporných čísel
//// 3.  sumu kladných hodnot
//// 4.  největší absolutní hodnotu
//// 5.  všechna kladná sudá čísla
//// 6.  seřaďte pole od nejmenších po největší hodnoty,
//// 7.  přeskočte první 3 prvky a sečtěte zbytek hodnot
///

var pocet_kladnych = numbers.Where(x => x > 0).Count();
Console.WriteLine($"pocet_kladnych: {pocet_kladnych}");

var pocet_zapornych = numbers.Where(x => x < 0).Count();
Console.WriteLine($"pocet_zapornych: {pocet_zapornych}");

var suma_kladnych = numbers.Where(x => x > 0).Sum();
Console.WriteLine($"suma_kladnych: {suma_kladnych}");

var nejv_abs = numbers.Select((cislo,index) => Math.Abs(cislo)).Max();
Console.WriteLine($"nejv_abs: {nejv_abs}");

var kladna_suda = numbers.Where(x => x > 0 && x % 2 == 0);
Console.WriteLine($"kladna_suda: {string.Join(", ", kladna_suda)}");

var ordered = numbers.OrderBy(x => x);
Console.WriteLine($"ordered: {string.Join(", ", ordered)}");

var skip3sum = numbers.Skip(3).Sum();
Console.WriteLine($"skip3sum: {skip3sum}");


var index_max_hodnoty = numbers
    .Select((cislo, index) => new { cislo, index })
    .OrderByDescending(x => x.cislo)
    .First();

Console.WriteLine($"nejvetsi cislo {index_max_hodnoty.cislo} je na indexu {index_max_hodnoty.index}");
    