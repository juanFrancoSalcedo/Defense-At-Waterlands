using DAW.Civiz;
using DAW.TechTree;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTreeController : TreeController
{
     [SerializeField] private RowBuildingTree[] rows = null;

    public override void SetCivi(CivilizationInfo civi)
    {
        for (int i = 0; i < rows.Length; i++)
            rows[i].DisplayCardBuilding(civi.Progress[i], civi.Buildings);
    }
}