using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DAW.Gameplay
{
    public class BuildingUnitController : UnitController, IDestinationable
    {
        public void SetDestination(Vector3 position)
        {
            print("Punto de reunion");
        }
    }
}
