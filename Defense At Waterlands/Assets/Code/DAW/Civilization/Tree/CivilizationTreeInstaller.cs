using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAW.Civiz
{
    public class CivilizationTreeInstaller : MonoBehaviour
    {
        [SerializeField] private CivilizationInfo civiToSet = null;
        [SerializeField] private TreeController[] treeController = null;

        void Start()
        {
            System.Array.ForEach(treeController, t => t.SetCivi(civiToSet));
        }
    }
}