using Scripts.Locomotion;
using UnityEngine;

namespace Scripts.Core
{
    public class TankController : MonoBehaviour
    {

        IObjectRotations objectRotations;
        IMover mover;
        IInputHandler inputHandler;
       
        Vector2 move;

        private void Start()
        {
            inputHandler = GetComponent<IInputHandler>();
            objectRotations = GetComponent<IObjectRotations>();
            mover = GetComponent<IMover>();
        }
        private void Update()
        {
            move = new Vector3(inputHandler.tankHorizontal, inputHandler.tankVertical);
            move.Normalize();
            if (move != Vector2.zero)
            {
                objectRotations.RotateTo(transform, move);
                mover.MoveTo(transform, Vector3.up);
            }

        }
    }
}