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
            if(!BufferSelection.Contains(unit))
                BufferSelection.Add(unit);
        }
        public static void RemoveBufferSelection(BaseUnitSelection unit) => BufferSelection.RemoveAll(r => ReferenceEquals(r, unit));
        public static void TurnBufferIntoSelection() 
        {
            var array = new BaseUnitSelection[BufferSelection.Count];
            BufferSelection.CopyTo(array);
            Selection = array.ToList();
            Selection.ForEach( s => Debug.Log(s.gameObject.name));
            Debug.Log(BufferSelection.Count);
        }
    }

}



