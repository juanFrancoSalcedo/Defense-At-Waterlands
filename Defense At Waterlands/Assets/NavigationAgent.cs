using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


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
