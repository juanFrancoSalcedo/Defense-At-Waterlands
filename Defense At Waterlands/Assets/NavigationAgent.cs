using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

<<<<<<< HEAD
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
=======

[RequireComponent(typeof(NavMeshAgent))]
public class NavigationAgent : MonoBehaviour
{
    [SerializeField] private Transform target = null;

    //TODO Inject this
    NavMeshAgent agentComponent => GetComponent<NavMeshAgent>();
    
    private void Awake()
    {
        
    }

    private void Update()
    {
    }

    public void Put() 
    {
        agentComponent.SetDestination(target.position);
    }
}
>>>>>>> 6eda13344b3ad50d7674cede8ee115287a2ce545
