using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;

public abstract class DamageCommand : Command
{
    [SerializeField] private int damageAmount;
    public int DamageAmount => damageAmount;
    
    public override async UniTask Execute() =>
        DamageAll();
    
    protected abstract List<Collider> FindAllCollidersNearby();
    public virtual List<T> FindAll<T>()
    {
        return FindAllCollidersNearby()
            .Select(contact => contact.gameObject.GetComponent<T>())
            .Where(component => component != null).ToList();
    }
    
    public virtual List<GameObject> FindAllGameObjects<T>()
    {
        return (from contact in FindAllCollidersNearby() 
            let component = contact.gameObject.GetComponent<T>() 
            where component != null 
            select contact.gameObject).ToList();
    }

    public virtual void DamageAll()
    {
        foreach (var damageable in FindAll<IDamageable>())
            damageable.Damage(DamageAmount);
    }
}
