using System;
using UnityEngine;
using TMPro;
using Scripts.Utilities;

namespace Scripts.Core
{
    public class Health : MonoBehaviour, IHealth
    {
        [SerializeField] TMP_Text score;
        [SerializeField] int health;

        public int _Health => health;

        public void TakeDamage(int damage)
        {
            if (health > 0)
            {
                health -= damage;
                score.text = health.ToString();
                if (health <= 0)
                {
                    if (Events.OnGameover != null)
                    {
                        Events.OnGameover.Invoke();
                    }
                }
            }
            else
            {
                if (Events.OnGameover != null)
                {
                    Events.OnGameover.Invoke();
                }
            }
        }
    }
}