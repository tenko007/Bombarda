using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class NotificationManagerForDebugOnly : MonoBehaviour, INotificationManager
    {
        [SerializeField] private HealthComponent _healthComponent;
        private void Start()
        {
            _healthComponent.OnGetDamage += ShowDamageNotification;
        }

        private void OnDestroy()
        {
            _healthComponent.OnGetDamage -= ShowDamageNotification;

        }

        private void ShowDamageNotification(int damage)
        {
            Debug.Log($"Player got damage: {damage.ToString()}");
        }
    }
}