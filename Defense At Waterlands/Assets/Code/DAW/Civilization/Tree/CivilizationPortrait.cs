using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DAW.Civiz
{
    [RequireComponent(typeof(Image))]
    public class CivilizationPortrait : MonoBehaviour, IPointerClickHandler
    {
        protected Image image => GetComponent<Image>();
        private CivilizationInfo info;

        public void OnPointerClick(PointerEventData eventData)
        {
            PlaceHolderInfoShower.DisplayInfo(info?.CivilizationDescriptionFeatures);
        }

        public void SetCivi(CivilizationInfo civi)
        {
            info = civi;
            image.sprite = info.SptFlag;
        }
    }
}