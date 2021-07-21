using System.Collections;
using UnityEngine;

namespace Scripts.Locomotion
{
    public class Mover : MonoBehaviour, IMover
    {
        [SerializeField]
        private float speed = 5f;

        public void MoveTo(Transform _transform, Vector3 to)
        {
            _transform.Translate(to * speed * Time.deltaTime);
           
        }
    }
}