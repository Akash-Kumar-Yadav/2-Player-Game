using Scripts.Locomotion;
using System.Collections;
using UnityEngine;

namespace Scripts.Weapon
{
    public class Bullet : MonoBehaviour
    {

        Rigidbody2D rb;
        [SerializeField] float speed;
        private void OnEnable()
        {
            if (rb == null)
            {
               rb = GetComponent<Rigidbody2D>();
            }

            rb.WakeUp();
            rb.AddForce(rb.transform.up * speed ,ForceMode2D.Impulse);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            rb.Sleep();
            transform.gameObject.SetActive(false);
        }

        private void OnDisable()
        {
            rb.Sleep();
            transform.gameObject.SetActive(false);
        }
    }
}