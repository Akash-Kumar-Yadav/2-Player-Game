using Scripts.Locomotion;
using Scripts.Utilities;
using System.Collections;
using UnityEngine;

namespace Scripts.Weapon
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ObjectPooler objectPooler;
        [SerializeField] Transform spawnPoint;
        [SerializeField] float waitTime;
        

        float fire;
       

        IInputHandler inputHandler;

        private void Start()
        {
            inputHandler = GetComponent<IInputHandler>();
        }
        private void Update()
        {
            if (inputHandler.canFire && Time.time > fire)
            {
                var obj = objectPooler.GetPoolObject();
                obj.transform.position = spawnPoint.position;
                obj.transform.rotation = spawnPoint.rotation;
                
              
               
                fire = Time.time + waitTime;
            }
        }
    }
}