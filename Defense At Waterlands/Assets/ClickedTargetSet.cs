using DAW.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedTargetSet : MonoBehaviour
{
    [SerializeField] private NavigationAgent agent = null;
    [SerializeField] private Transform target = null;
    Camera cam;
    RaycastHit raycast;
    private void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        { 
            if(Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                target.position =  hit.point;
                agent.Put();
            }
        }

    }
}
