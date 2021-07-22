using System;
using UnityEngine;

namespace Scripts.Utilities
{
    public class UniqueID : MonoBehaviour
    {
        [SerializeField] string id = Guid.NewGuid().ToString();

        public string ID => id;

        [ContextMenu("Generate ID")]
        public void GenerateID()
        {
           string newid = Guid.NewGuid().ToString();
            id = newid;
           
        }
    }
}