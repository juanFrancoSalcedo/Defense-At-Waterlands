using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAW.Gameplay
{
    public class DestinationAgentController : MonoBehaviour
    {
        [SerializeField] private Transform target = null;
        private DestinationAgent model = new DestinationAgent();
        Camera cam;
        private void Start() => cam = Camera.main;

        void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
                {
                    target.position = hit.point;
                    model.SetSelectionDestination(target);
                }
            }
        }
    }

    public class DestinationAgent 
    {
        public void SetSelectionDestination(Transform target) 
        {
            var selection = SelectionUnits.Selection;
            selection.ForEach(t =>
            {
                if (t.TryGetComponent(out IDestinationable destiny))
                    destiny.SetDestination(target.position);
            });
        }
    }
}