using UnityEngine;

namespace DAW.Civiz
{
    public class CivilizationElement : ScriptableObject
    {
        [SerializeField] protected string nameE = "";
        public string NameE => nameE;
        [SerializeField] protected string description = "";
        public string Description => description;
        public Sprite image;
    }
}