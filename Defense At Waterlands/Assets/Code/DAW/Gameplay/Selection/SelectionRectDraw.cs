using UnityEngine;

namespace DAW.Gameplay
{
    public static class SelectionRectDraw
    {

        static Texture2D _whiteTexture;
        public static Texture2D WhiteTexture
        {
            get
            {
                if (_whiteTexture == null)
                {
                    _whiteTexture = new Texture2D(1, 1);
                    _whiteTexture.SetPixel(0, 0, Color.white);
                    _whiteTexture.Apply();
                }

                return _whiteTexture;
            }
        }
        public static Color ColorQuad { get; set; }
        public static void DrawScreenRectBorder(Rect rect, float thickness)
        {
            // Top
            DrawScreenRect(new Rect(rect.xMin, rect.yMin, rect.width, thickness));
            // Left
            DrawScreenRect(new Rect(rect.xMin, rect.yMin, thickness, rect.height));
            // Right
            DrawScreenRect(new Rect(rect.xMax - thickness, rect.yMin, thickness, rect.height));
            // Bottom
            DrawScreenRect(new Rect(rect.xMin, rect.yMax - thickness, rect.width, thickness));
        }

        public static void DrawScreenRect(Rect rect)
        {
            GUI.color = ColorQuad;
            GUI.DrawTexture(rect, WhiteTexture);
        }
    }
}
