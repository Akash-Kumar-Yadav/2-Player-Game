using UnityEngine;

namespace Scripts.Locomotion
{
    public interface IMover
    {
        void MoveTo(Transform _transform, Vector3 to);
    }
}