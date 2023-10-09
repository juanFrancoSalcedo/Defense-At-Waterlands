
using UnityEngine;

namespace DAW.Gameplay
{
    [RequireComponent(typeof(NavigationAgent))]
    public class MobileUnitController : UnitController, IDestinationable
    { 
        NavigationAgent agent => GetComponent<NavigationAgent>();

        public void SetDestination(Vector3 position)
        {
            agent.SetDestination(position);
        }
    }
}



