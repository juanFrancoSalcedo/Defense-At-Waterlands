using DAW.Tech;
using DAW.Units;
using System.Collections.Generic;
using UnityEngine;

namespace DAW.Civiz
{
    [CreateAssetMenu(fileName = "New Civi", menuName = "DAW Assets/Civilization Info")]
    public class CivilizationInfo : ScriptableObject 
    {
        [SerializeField] private Sprite sptFlag = null;
        public Sprite SptFlag => sptFlag;

        [TextArea(1,5)]
        [SerializeField] private string civilizationDescriptionFeatures = "";
        public string CivilizationDescriptionFeatures => civilizationDescriptionFeatures;

        [SerializeField] private Civilization civi = null;
        [SerializeField] private ImprovementTechInfo[] techs;
        public ImprovementTechInfo[] Techs => techs;

        [SerializeField] private AdvanceTechInfo[] progress;
        public AdvanceTechInfo[] Progress => progress;
        public Civilization GetCiviCopy() => civi.Copy();

        [SerializeField] private MobileUnitInfo[] mobileUnits = null;
        public MobileUnitInfo[] MobileUnits => mobileUnits;

        [SerializeField] private BuildingInfo[] buildings= null;
        public BuildingInfo[] Buildings => buildings;
    }
}
