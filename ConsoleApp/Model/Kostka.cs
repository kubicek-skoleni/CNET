namespace ConsoleApp.Model
{
    public class Kostka
    {
     
        public int PocetStran = 6;

        public int Hod()
        {
            return Random.Shared.Next(1, PocetStran + 1);
        }
    }
}
