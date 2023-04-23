using UnityEngine;

public static class RectTransformExtensions
{
    public static void AnchorToCenter(this RectTransform rect)
    {
        rect.anchorMin = new Vector2(0.5f, 0.5f);
        rect.anchorMax = new Vector2(0.5f, 0.5f);
        rect.anchoredPosition = Vector3.zero;
    }
}



