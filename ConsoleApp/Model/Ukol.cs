namespace ConsoleApp.Model
{
    /// <summary>
    /// Reprezetuje jeden úkol (TODO item)
    /// </summary>
    public class Ukol
    {
        public string Popis;
        public bool Hotovo = false;

        /// <summary>
        /// Zobrazí úkol ve formátu "[X] popis" nebo "[ ] popis"
        /// </summary>
        public string Zobrazit()
        {
            if (Hotovo)
                return $"[X] {Popis}";
            else
                return $"[ ] {Popis}";
        }
    }
}
