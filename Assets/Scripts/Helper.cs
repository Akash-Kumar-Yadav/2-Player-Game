using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Helper : MonoBehaviour
    {
       
        [SerializeField] float speed;
        [SerializeField] float turnSpeed;
        float moveX, moveY;
        private void Update()
        {
            moveX = Input.GetAxisRaw("Horizontal");
            moveY = Input.GetAxisRaw("Vertical");

            transform.Translate(0,moveY * speed * Time.deltaTime,0);
            transform.Rotate(0,0,moveX * -turnSpeed * Time.deltaTime);
           
        }
    }
}
