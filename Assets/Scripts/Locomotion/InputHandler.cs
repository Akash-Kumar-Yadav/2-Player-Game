using System.Collections;
using UnityEngine;

namespace Scripts.Locomotion
{
    public class InputHandler : MonoBehaviour, IInputHandler
    {
        [SerializeField] Joystick tankJoystick;

        public float tankHorizontal => tankJoystick.Horizontal;
        public float tankVertical => tankJoystick.Vertical;


    }
}