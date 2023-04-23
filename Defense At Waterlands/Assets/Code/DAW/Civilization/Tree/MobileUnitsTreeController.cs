using DAW.Civiz;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAW.TechTree
{
    public class MobileUnitsTreeController : TreeController
    {
        [SerializeField] private CivilizationInfo prototype = null;
        [SerializeField] private RowMobileUnitTree[] rows = null;
        private void Start() => SetCivi(prototype);

        public override void SetCivi(CivilizationInfo civi)
        {
            for (int i = 0; i < rows.Length; i++)
                rows[i].DisplayCardUnit(civi.Progress[i], civi.MobileUnits);
        }
    }
}