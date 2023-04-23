using UnityEngine;
using UnityEngine.EventSystems;

namespace DAW.Tech
{
    public class TechCard : Portrait
    {
        public override void DisplayCard() => image.sprite = Info.image;
        public override void DisplayCardInfo() => PlaceHolderInfoShower.DisplayInfo(info.Description);
        public override void OnPointerClick(PointerEventData eventData)=> DisplayCardInfo();
    }
}