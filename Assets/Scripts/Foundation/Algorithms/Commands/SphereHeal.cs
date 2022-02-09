using UnityEngine;

[CreateAssetMenu(menuName = "Commands/SphereHeal", fileName = "SphereHeal")]
public class SphereHeal : SphereDamage
{
    public override void DamageAll()
    {
        foreach (var damageable in FindAll<IHealable>())
            damageable.Heal(Amount);
    }
}
