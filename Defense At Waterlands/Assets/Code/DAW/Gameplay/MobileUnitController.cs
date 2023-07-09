
using UnityEngine;

namespace DAW.Gameplay
{
    public class MobileUnitController : UnitController, IDestinationable
    { 
        NavigationAgent agent => GetComponent<NavigationAgent>();

        public void SetDestination(Vector3 position)
        {
            agent.SetDestination(position);
        }
    }
}



