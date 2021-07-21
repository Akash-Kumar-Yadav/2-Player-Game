using UnityEngine;

namespace Scripts.Locomotion
{
    public interface IObjectRotations
    {
        void RotateTo(Transform transform, Vector3 to);
    }
}