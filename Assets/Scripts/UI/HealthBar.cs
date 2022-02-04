using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Health health;
        [SerializeField] private Image bar;
        [SerializeField] private TMP_Text healthText;

        private int _maxHealth;
        
        private void Start()
        {
            _maxHealth = health.MaxPoints;
            health.OnGetDamage += UpdateHealth;
            health.OnGetHeal += UpdateHealth;
        }

        private void OnDestroy()
        {
            health.OnGetDamage -= UpdateHealth;
            health.OnGetHeal -= UpdateHealth;
        }

        private void UpdateHealth(int damage, int healthRemain)
        {
            bar.fillAmount = healthRemain * 1f / _maxHealth;
            healthText.text = $"{healthRemain.ToString()}/{_maxHealth.ToString()}";
        }
    }
}