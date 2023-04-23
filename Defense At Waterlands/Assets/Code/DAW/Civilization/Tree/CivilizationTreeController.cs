using UnityEngine;

namespace DAW.Civiz
{
    public class CivilizationTreeController : TreeController
    {

        [SerializeField] private CivilizationTreeView view = null;

        public override void SetCivi(CivilizationInfo civi)
        {
            view.DisplayCiviIcon(civi);
        }

        [System.Serializable]
        public class CivilizationTreeView
        {
            [SerializeField] private CivilizationPortrait portraitCivi = null;

            public void DisplayCiviIcon(CivilizationInfo civiInfo) => portraitCivi.SetCivi(civiInfo);
        }
    }
}