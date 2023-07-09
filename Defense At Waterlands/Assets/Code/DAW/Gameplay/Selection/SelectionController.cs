using UnityEngine;
using UnityEngine.Diagnostics;

namespace DAW.Gameplay
{
    public class SelectionController : MonoBehaviour
    {
        [SerializeField] private Color colorQuad = Color.black;
        private Vector3 firstClickPosition;
        private bool dragging;
        private Camera cam = null;

        private void Awake()
        {
            cam = Camera.main;
            SelectionRectDraw.ColorQuad = colorQuad;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                firstClickPosition = Input.mousePosition;
                dragging = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                dragging = false;
                SelectionUnits.TurnBufferIntoSelection();
            }


            if (dragging && firstClickPosition != Input.mousePosition)
            {
                var bounds = SelectionRect.GetViewportBounds(cam,firstClickPosition,Input.mousePosition);
                SelectionRect.SelectUnitsInDraggingBox(bounds);
            }

        }

        private void OnGUI()
        {
            if (!dragging)
                return;
            var rect = GetScreenRect(firstClickPosition, Input.mousePosition);
            SelectionRectDraw.DrawScreenRect(rect);
            SelectionRectDraw.DrawScreenRectBorder(rect, 1);
        }
       

        private Rect GetScreenRect(Vector3 screenPosition1, Vector3 screenPosition2)
        {
            screenPosition1.y = Screen.height - screenPosition1.y;
            screenPosition2.y = Screen.height - screenPosition2.y;
            var topLeft = Vector3.Min(screenPosition1, screenPosition2);
            var bottomRight = Vector3.Max(screenPosition1, screenPosition2);
            return Rect.MinMaxRect(topLeft.x, topLeft.y, bottomRight.x, bottomRight.y);
        }
    }
}
