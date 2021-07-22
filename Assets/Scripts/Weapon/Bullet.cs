using Scripts.Core;
using Scripts.Locomotion;
using Scripts.Utilities;
using System.Collections;
using UnityEngine;

namespace Scripts.Weapon
{
    public class Bullet : MonoBehaviour
    {

        Rigidbody2D rb;
        public string parentObjectID;

        [SerializeField] float speed;
         int damage = 1;
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
            if (collision.gameObject.GetComponent<UniqueID>() && collision.gameObject.GetComponent<UniqueID>().ID != parentObjectID)
            {
                collision.gameObject.GetComponent<IHealth>().TakeDamage(damage);
            }
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