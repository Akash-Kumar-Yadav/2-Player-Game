using Scripts.Locomotion;
using System.Collections;
using UnityEngine;

namespace Scripts.Core
{
    public class TurrentController : MonoBehaviour
    {

        IObjectRotations objectRotations;
        IInputHandler inputHandler;
        Vector2 move;

        private void Start()
        {
            inputHandler = GetComponentInParent<IInputHandler>();
            objectRotations = GetComponentInParent<IObjectRotations>();
        }
        private void Update()
        {
            move = new Vector3(inputHandler.turrentHorizontal, inputHandler.turrentVertical);
            move.Normalize();
            if (move != Vector2.zero)
            {
                objectRotations.RotateTo(transform, move);
            }

        }
    }
}