using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DAW.Tech;
using DAW.Civiz;
using UnityEngine.UI;

namespace DAW.TechTree
{
    public class TechTreeController: TreeController
    {
        [SerializeField] private CivilizationInfo prototype = null;
        [SerializeField] private RowTechTree[] rows = null;
        private void Start() => SetCivi(prototype);
        public override void SetCivi(CivilizationInfo civi) 
        {
            for (int i = 0; i < rows.Length; i++)
                rows[i].DisplayCarTech(civi.Progress[i],civi.Techs);
        }
    }
}



