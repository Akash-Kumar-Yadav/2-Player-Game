using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Utilities
{
    public class ObjectPooler : MonoBehaviour
    {
        [SerializeField] 
        private GameObject prefab;
        [SerializeField]
        private int prefabAmount;
        [SerializeField] 
        private GameObject parentObject;

        [SerializeField]
        private List<GameObject> poolObjects = new List<GameObject>();

        private void Start()
        {
            for (int i = 0; i < prefabAmount; i++)
            {
                var obj = Instantiate(prefab);
                obj.transform.SetParent(parentObject.transform);
                obj.SetActive(false);
                poolObjects.Add(obj);
            }
        }

        public GameObject GetPoolObject()
        {
            for (int i = 0; i < poolObjects.Count; i++)
            {
                if (!poolObjects[i].activeInHierarchy)
                {
                   
                    return poolObjects[i];
                }
            }

            return null;
        }

    }
}