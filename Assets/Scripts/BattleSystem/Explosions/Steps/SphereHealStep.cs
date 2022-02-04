using System;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/SphereHealStep", fileName = "SphereHealStep")]
    public class SphereHealStep : SphereDamageStep
    {
        public override void DamageAll()
        {
            foreach (var damageable in FindAll<IHealable>())
                damageable.Heal(Amount);
        }
    }
}