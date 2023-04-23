using DAW.Civiz;
using UnityEngine;

namespace DAW.Tech
{
    public class TechInfo : CivilizationElement
    {
        [SerializeField] protected TechInfo techRequeriment;
        public TechInfo TechRequeriment => techRequeriment;
    }
}