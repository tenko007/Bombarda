using UnityEngine;

[CreateAssetMenu(menuName = "Commands/SphereHeal", fileName = "SphereHeal")]
public class SphereHeal : SmartSphereDamage
{
    public override void DamageAll()
    {
        foreach (var healable in FindAll<IHealable>())
            healable.Heal(DamageAmount);
    }
}
