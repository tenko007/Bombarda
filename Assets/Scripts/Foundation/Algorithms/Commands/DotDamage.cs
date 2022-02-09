using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/DotDamage", fileName = "DotDamage")]
public class DotDamage : SmartSphereDamage
{
    [SerializeField] private float seconds; 
    [SerializeField] private float delay; 
    [SerializeField] private GameObject visualEffect;
    //[SerializeField] private DotData dotData;

    public override void DamageAll()
    {
        foreach (var damageableObject in FindAllGameObjects<IDamageable>())
            damageableObject.AddComponent<DotEffect>().SetDotData(
                new DotData(seconds, delay, DamageAmount, visualEffect));
    }
}