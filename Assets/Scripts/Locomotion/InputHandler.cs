using System.Collections;
using UnityEngine;

namespace Scripts.Locomotion
{
    public class InputHandler : MonoBehaviour, IInputHandler
    {
        [SerializeField] Joystick tankJoystick;
        [SerializeField] Joystick turrentJoystick;

        public float tankHorizontal => tankJoystick.Horizontal;
        public float tankVertical => tankJoystick.Vertical;
        public float turrentHorizontal => turrentJoystick.Horizontal;
        public float turrentVertical => turrentJoystick.Vertical;


    }
}