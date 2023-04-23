using UnityEngine;
using DAW.Tech;
using System.Linq;
using System.Collections.Generic;
using DAW.Units;

namespace DAW.TechTree
{
    public class RowBuildingTree : MonoBehaviour
    {
        [SerializeField] private TechCard prototypeTechCard= null;
        [SerializeField] private UnitCard prototype = null;
        [SerializeField] private RectTransform containerAdvance = null;
        [SerializeField] private RectTransform containerElements = null;
        private TechCard mainCard = null;
        private List<UnitCard> techCards = new List<UnitCard>();

        public void DisplayCardBuilding(AdvanceTechInfo info, BuildingInfo[] buildings)
        {
            var techCard = Instantiate(prototypeTechCard, containerAdvance);
            mainCard = techCard;
            mainCard.Info = info;
            mainCard.DisplayCard();
            ((RectTransform)mainCard.transform).AnchorToCenter();

            var list = buildings.ToList();
            // list
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

