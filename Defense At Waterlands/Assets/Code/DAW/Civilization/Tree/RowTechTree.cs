using UnityEngine;
using UnityEngine.UI;
using DAW.Tech;
using System.Linq;
using System.Collections.Generic;

namespace DAW.TechTree
{
    public class RowTechTree: MonoBehaviour
    {
        [SerializeField] private TechCard prototype = null;
        [SerializeField] private RectTransform containerAdvance = null;
        [SerializeField] private RectTransform containerElements = null;
        private TechCard mainCard = null;
        private List<TechCard> techCards = new List<TechCard>();

        public void DisplayCarTech(AdvanceTechInfo info, ImprovementTechInfo[] improvements) 
        {
            mainCard = CreateCard(containerAdvance);
            mainCard.Info = info;
            mainCard.DisplayCard();
            ((RectTransform)mainCard.transform).AnchorToCenter();

            var list = improvements.ToList();
            var anotherList = list.Where(t => t.TechRequeriment == info).ToList();

            anotherList.ForEach(a => {
                techCards.Add(CreateCard(containerElements));
                techCards.Last().Info = a;
                techCards.Last().DisplayCard();
            });
        }
        //TODO factory this
        private TechCard CreateCard(Transform origin) 
        {
            var techCard = Instantiate(prototype,origin);
            return techCard;
        }
    }
}

