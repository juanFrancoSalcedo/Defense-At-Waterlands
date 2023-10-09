using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DAW.Gameplay
{
    /// <summary>
    /// Storage the selection 
    /// </summary>
    public static class SelectionUnits
    {
        public static List<BaseUnitSelection> BufferSelection { get; private set; } = new List<BaseUnitSelection>();
        public static List<BaseUnitSelection> Selection { get;  private set; } = new List<BaseUnitSelection>();

        public static void AddBufferSelection(BaseUnitSelection unit)
        {
            if (!BufferSelection.Contains(unit))
                BufferSelection.Add(unit);
            if(unit is MobileUnitSelection)
                Switch();
        }
        public static void RemoveBufferSelection(BaseUnitSelection unit) => BufferSelection.RemoveAll(r => ReferenceEquals(r, unit));


        public static void Switch() 
        {
            if(AnyMobile())
                DeselectBuildings();
        }

        public static bool AnyMobile() => BufferSelection.Any(s => s is MobileUnitSelection);

        public static void DeselectBuildings() 
        {
            var items = BufferSelection.Where(s => s is BuildingUnitSelection);
            items.ToList().ForEach(s=>s.Deselect());
        }


        public static void TurnBufferIntoSelection() 
        {
            var array = new BaseUnitSelection[BufferSelection.Count];
            BufferSelection.CopyTo(array);
            Selection = array.ToList();
        }
    }

}



