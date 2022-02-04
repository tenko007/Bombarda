using System;
using UnityEngine;

namespace BattleSystem
{
    public class Death : MonoBehaviour
    {
        private Health _health;
        private void Start()
        {
            _health = this.GetComponent<Health>();
            if (_health != null)
                _health.OnZeroHealth += Die;
        }

        private void Die()
        {
            Destroy(this.gameObject);
        }
    }
}