using System;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/SphereDamageStep", fileName = "SphereDamageStep")]
    public class SphereDamageStep : DamageStep
    {
        [SerializeField] private float radius;
        protected override Collider[] FindAllCollidersNearby()
        {
            return Physics.OverlapSphere(ParentTransform.position, radius);
        }
    }
}