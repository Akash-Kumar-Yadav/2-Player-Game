using System.Collections;
using UnityEngine;

namespace Scripts.Locomotion
{
    public class ObjectRotations : MonoBehaviour, IObjectRotations
    {
        [SerializeField]
        private float turnSpeed = 10f;

        public void RotateTo(Transform transform, Vector3 to)
        {
            Quaternion rot = Quaternion.LookRotation(Vector3.forward, to);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, turnSpeed * Time.deltaTime);
        }
    }
}