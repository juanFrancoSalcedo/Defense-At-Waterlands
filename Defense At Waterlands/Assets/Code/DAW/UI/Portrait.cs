using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DAW.Tech;
using DAW.Civiz;

namespace DAW
{
    [RequireComponent(typeof(Image))]
    public abstract class Portrait : MonoBehaviour, IPointerClickHandler
    {
        protected Image image => GetComponent<Image>();
        // TODO rememvber this will be use fot all i mean for units too, so you'de think in other info
        protected CivilizationElement info;
        public CivilizationElement Info { get => info; set => info = value; }
        public abstract void DisplayCard();
        public abstract void DisplayCardInfo();
        public abstract void OnPointerClick(PointerEventData eventData);
    }

}


