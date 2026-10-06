public class BankovniUcet
{
    private decimal _zustatek;
    public string MajitelUctu;
    public const int MaxPocetVyberu = 5;

    public bool VyberPenez(decimal castka)
    {
        decimal NovyZustatek = _zustatek - castka;
        if (NovyZustatek < 0) return false;
        _zustatek = NovyZustatek;
        return true;
    }
}