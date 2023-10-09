namespace DAW.Civiz
{
    [System.Serializable]
    public class Civilization : ICopy<Civilization>
    {
        public string NameCivilization;
        public Civilization Copy() => (Civilization)this.MemberwiseClone();
    }
}
