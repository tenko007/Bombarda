public class HealExplosion : SphereExplosion
{
    public override void DamageAll()
    {
        foreach (var healable in FindAll<IHealable>())
            healable.Heal((int)damage);
    }
}