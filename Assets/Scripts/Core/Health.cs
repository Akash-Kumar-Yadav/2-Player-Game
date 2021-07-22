using System.Collections;
using UnityEngine;
using TMPro;

namespace Scripts.Core
{
    public class Health : MonoBehaviour, IHealth
    {
        [SerializeField] TMP_Text score;
        [SerializeField] int health;
        public bool IsDead { get; private set; }

        private void Start()
        {
            IsDead = false;
        }
        public void TakeDamage(int damage)
        {
            if (health > 0)
            {
                health -= damage;
                score.text = health.ToString();
                if (health <= 0)
                {
                    IsDead = true;
                }
            }
            else
            {
                IsDead = true;
            }
        }
    }
}