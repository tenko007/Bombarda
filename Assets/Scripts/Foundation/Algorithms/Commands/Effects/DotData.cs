using System;
using UnityEngine;

[Serializable]
public class DotData
{
    [SerializeField] private float delay; 
    [SerializeField] private int oneTickDamage; 
    [SerializeField] private float seconds; 
    [SerializeField] private GameObject visualEffect; 
    
    public float Delay => delay; 
    public int OneTickDamage => oneTickDamage; 
    public float Seconds => seconds; 
    public GameObject VisualEffect => visualEffect; 

    
    public DotData(float seconds, float delay, int oneTickDamage, GameObject visualEffect)
    {
        this.seconds = seconds;
        this.delay = delay;
        this.oneTickDamage = oneTickDamage;
        this.visualEffect = visualEffect;
    }
}