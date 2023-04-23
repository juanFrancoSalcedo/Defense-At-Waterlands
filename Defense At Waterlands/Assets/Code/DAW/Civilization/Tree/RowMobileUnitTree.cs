using DAW.Tech;
using DAW.Units;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DAW.TechTree
{
    public class RowMobileUnitTree : MonoBehaviour
    {
        [SerializeField] private TechCard prototypeTech = null;
        [SerializeField] private UnitCard prototype = null;
        [SerializeField] private RectTransform containerAdvance = null;
        [SerializeField] private RectTransform containerElements = null;
        private TechCard mainCard = null;
        private List<UnitCard> techCards = new List<UnitCard>();

        public void DisplayCardUnit(AdvanceTechInfo info, MobileUnitInfo[] units)
        {
            var techCard = Instantiate(prototypeTech, containerAdvance);
            mainCard = techCard;
            mainCard.Info = info;
            mainCard.DisplayCard();
            ((RectTransform)mainCard.transform).AnchorToCenter();

            var list = units.ToList();
            var anotherList = list.Where(t => t.TechRequeriment == info).ToList();

            anotherList.ForEach(a =>
            {
                techCards.Add(CreateCard(containerElements));
                techCards.Last().Info = a;
                techCards.Last().DisplayCard();
            });
        }
        //TODO factory this
        private UnitCard CreateCard(Transform origin)
        {
            var techCard = Instantiate(prototype, origin);
            return techCard;
        }
    }
}