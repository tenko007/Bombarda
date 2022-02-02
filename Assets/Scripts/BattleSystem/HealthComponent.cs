using System;
using UnityEngine;

[Serializable]
public class HealthComponent : MonoBehaviour, IDamageable, IHealable
{
    [SerializeField] private int points;
    public int Points => points;
    
    public event Action<int> OnGetDamage;
    public event Action<int> OnGetHeal;
    public event Action OnZeroHealth;

    public int Damage(int damagePoints)
    {
        if (damagePoints < 0)
            return 0;
        
        damagePoints = ReduceDamage(damagePoints);

        this.points -= damagePoints;
        OnGetDamage?.Invoke(damagePoints);
        if (this.points <= 0)
            OnZeroHealth?.Invoke();

        return damagePoints;
    }
    
    private int ReduceDamage(int damagePoints)
    {
        return damagePoints; // TODO 
    }

    public int Heal()
    {
        throw new NotImplementedException();
    }
}