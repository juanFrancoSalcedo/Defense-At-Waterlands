using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace DAW.Gameplay
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class NavigationAgent : MonoBehaviour
    {
        NavMeshAgent agentComponent => GetComponent<NavMeshAgent>();
        public void SetDestination(Vector3 posi)
        {
            // TODO ask if is posible reach given position
            agentComponent.SetDestination(posi);
        }
    }
}