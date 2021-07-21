using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class TankController : MonoBehaviour
    {
        [SerializeField] Joystick joystick;
        [SerializeField] float speed;
        [SerializeField] float turnSpeed;

        Vector2 move;
        private void Update()
        {
            move = new Vector3(joystick.Horizontal, joystick.Vertical);
            move.Normalize();
            if (move != Vector2.zero)
            {
                Quaternion rot = Quaternion.LookRotation(Vector3.forward, move);
                transform.rotation = Quaternion.Slerp(transform.rotation,rot,turnSpeed*Time.deltaTime);
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
               

        }
    }
}