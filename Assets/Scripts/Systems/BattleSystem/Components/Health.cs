using System;
using UnityEngine;

[Serializable]
public class Health : MonoBehaviour, IDamageable, IHealable
{
    [SerializeField] private int maxPoints;
    [SerializeField] private int points;
    public int Points => points;
    public int MaxPoints => maxPoints;
    
    public event Action<int, int> OnGetDamage;
    public event Action<int, int> OnGetHeal;
    public event Action OnZeroHealth;

    private void Start()
    {
        points = maxPoints;
    }

    public int Damage(int damagePoints)
    {
        if (damagePoints < 0) return 0;
        
        this.points -= damagePoints;
        OnGetDamage?.Invoke(damagePoints, this.points);
        if (this.points <= 0)
            OnZeroHealth?.Invoke();

        return damagePoints;
    }


    public int Heal(int healPoints)
    {
        if (healPoints < 0) return 0;

        if (this.points + healPoints > maxPoints)
            healPoints = maxPoints - this.points;
        this.points += healPoints;
        OnGetHeal?.Invoke(healPoints, this.points);

        return healPoints;
    }
}