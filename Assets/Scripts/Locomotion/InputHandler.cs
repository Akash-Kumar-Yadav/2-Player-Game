using System.Collections;
using UnityEngine;

namespace Scripts.Locomotion
{
    public class InputHandler : MonoBehaviour, IInputHandler
    {
        [SerializeField] Joystick tankJoystick;
        [SerializeField] Joystick turrentJoystick;

        [SerializeField] bool _canFire;
        public float tankHorizontal => tankJoystick.Horizontal;
        public float tankVertical => tankJoystick.Vertical;
        public float turrentHorizontal => turrentJoystick.Horizontal;
        public float turrentVertical => turrentJoystick.Vertical;
        public bool canFire => _canFire;

        private void Update()
        {
            if (turrentHorizontal != 0 || turrentVertical != 0)
            {
                _canFire = true;
            }
            else
            {
                _canFire = false;
            }
        }


    }
}