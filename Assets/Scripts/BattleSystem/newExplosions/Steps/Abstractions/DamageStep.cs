using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    public abstract class DamageStep : Step
    {
        [SerializeField] private int amount;
        public int Amount => amount;
        
        public override async UniTask Execute()
        {
            DamageAll();
        }
        protected abstract Collider[] FindAllCollidersNearby();
        public virtual List<T> FindAll<T>()
        {
            List<T> list = new List<T>();
            foreach (var contact in FindAllCollidersNearby())
            {
                var component = contact.gameObject.GetComponent<T>();
                if (component != null)
                    list.Add(component);
            }
            return list;
        }

        public virtual void DamageAll()
        {
            foreach (var damageable in FindAll<IDamageable>())
                damageable.Damage(Amount);
        }
    }
}