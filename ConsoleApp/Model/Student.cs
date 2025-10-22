
namespace ConsoleApp.Model
{
    public class Student
    {
        public string Jmeno;
        public string Prijmeni;
        public string Trida;
        public int RokNarozeni;
        public Adresa TrvalaAdresa;

        public Student(string jmeno, int rok)
        {
            Jmeno = jmeno;
            RokNarozeni = rok;
        }

        public int Vek()
        {
            int aktualniRok = DateTime.Now.Year;
            return aktualniRok - RokNarozeni;
        }

        public string CeleJmeno()
        {
            return $"{Jmeno} {Prijmeni}";
        }
    }
}
