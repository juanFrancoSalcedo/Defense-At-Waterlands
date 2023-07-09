using UnityEngine;

namespace DAW.Gameplay
{
    public static class SelectionRect
    {

        public static void SelectUnitsInDraggingBox(Bounds selectionBounds)
        {
            //Bounds selectionBounds = 
            GameObject[] selectableUnits = GameObject.FindGameObjectsWithTag("Unit");
            bool inBounds;
            foreach (GameObject unit in selectableUnits)
            {
                inBounds = selectionBounds.Contains(
                    Camera.main.WorldToViewportPoint(unit.transform.position)
                );
                if (inBounds)
                    unit.GetComponent<BaseUnitSelection>().Select();
                else
                    unit.GetComponent<BaseUnitSelection>().Deselect();
            }
        }

        public static Bounds GetViewportBounds(Camera camera, Vector3 screenPosition1, Vector3 screenPosition2)
        {
            var v1 = Camera.main.ScreenToViewportPoint(screenPosition1);
            var v2 = Camera.main.ScreenToViewportPoint(screenPosition2);
            var min = Vector3.Min(v1, v2);
            var max = Vector3.Max(v1, v2);
            min.z = camera.nearClipPlane;
            max.z = camera.farClipPlane;

            var bounds = new Bounds();
            bounds.SetMinMax(min, max);
            return bounds;
        }
    }
}
