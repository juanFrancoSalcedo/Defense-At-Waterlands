using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAW.Gameplay
{
    public class BuildingUnitSelection : BaseUnitSelection
    {
        [SerializeField] private View view = null;
        public override void Deselect()
        {
            SelectionUnits.RemoveBufferSelection(this);
            view.DisplaySelection(false);
        }

        public override void Select()
        {
            // for just use buildg with buildings, mobiles with mobiles
            if (SelectionUnits.AnyMobile())
                return;
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
