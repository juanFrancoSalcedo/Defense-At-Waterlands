using DAW.Civiz;
using DAW.Tech;
using UnityEngine;


namespace DAW.Units
{
    public class UnitInfo : CivilizationElement
    {
        [SerializeField] protected TechInfo techRequeriment;
        public TechInfo TechRequeriment => techRequeriment;
    }
}