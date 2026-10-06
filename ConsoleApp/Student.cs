namespace ConsoleApp
{
    /// <summary>
    /// Student v sytému školní docházky
    /// </summary>
    internal class Student
    {
        public string Jmeno;
        public string Prijmeni;

        /// <summary>
        /// Třída z výčtu tříd z číslníku z databáze
        /// </summary>
        public string Trida;

        public int RokNarozeni;

        public Adresa AdresaDoma;

        /// <summary>
        /// Aktuální věk studenta, počíta se z roku narození.
        /// </summary>
        /// <returns>celé číslo</returns>
        public int Vek()
        {
            int aktualniRok = DateTime.Now.Year;
            return aktualniRok - RokNarozeni;
        }

        public string CeleJmeno()
        {
            return $"{Jmeno} {Prijmeni}";
        }

        public override string ToString()
        {
            return $"student: {CeleJmeno()}, {RokNarozeni}, {Trida}";
        }
    }
}
