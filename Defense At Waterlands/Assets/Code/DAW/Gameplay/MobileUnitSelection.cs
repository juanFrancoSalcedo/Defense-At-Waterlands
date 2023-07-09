using System.Collections;
using UnityEngine.Diagnostics;


namespace DAW.Gameplay
{
    public class MobileUnitSelection : BaseUnitSelection
    {
        public override void Deselect() => SelectionUnits.RemoveBufferSelection(this);
        public override void Select() => SelectionUnits.AddBufferSelection(this);
    }
}



