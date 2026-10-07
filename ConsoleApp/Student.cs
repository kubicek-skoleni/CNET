namespace ConsoleApp
{
    /// <summary>
    /// Student v sytému školní docházky
    /// </summary>
    internal class Student
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        /// <summary>
        /// Třída z výčtu tříd z číslníku z databáze
        /// </summary>
        public string Trida { get; set; }

        public int RokNarozeni { get; set; }

        public Adresa AdresaDoma { get; set; }

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
