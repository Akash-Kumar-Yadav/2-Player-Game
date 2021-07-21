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
        GameObject player;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player1");
            inputHandler = player.GetComponent<IInputHandler>();
            objectRotations = player.GetComponent<IObjectRotations>();
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