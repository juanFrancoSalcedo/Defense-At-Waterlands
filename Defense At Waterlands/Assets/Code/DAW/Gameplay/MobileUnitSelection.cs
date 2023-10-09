using System.Collections;
using UnityEngine;

namespace DAW.Gameplay
{
    public class MobileUnitSelection : BaseUnitSelection
    {
        [SerializeField] private View view;
        public override void Deselect()
        {
            SelectionUnits.RemoveBufferSelection(this);
            view.DisplaySelection(false);
        }

        public override void Select()
        {
            SelectionUnits.AddBufferSelection(this);
            view.DisplaySelection(true);
        }

        [System.Serializable]
        public class View 
        {
            [SerializeField] private GameObject _selectionCircle;
            public void DisplaySelection(bool active) => _selectionCircle.SetActive(active);
        }
    }

}



