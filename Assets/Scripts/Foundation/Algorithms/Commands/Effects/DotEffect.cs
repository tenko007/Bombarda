using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class DotEffect : MonoEffect
{
    private DotData _data; 
    public void SetDotData(DotData data) =>
        this._data = data;

    private Health thisHealth;
    private GameObject EffectGameObject;
    private float startTime;
    private async void Start()
    {
        thisHealth = GetComponent<Health>();
        startTime = Time.time;
        EffectGameObject = Instantiate(_data.VisualEffect, this.transform);
        await DotTask();

        Destroy(this);
    }

    private void OnDestroy() =>
        Destroy(EffectGameObject);

    private async UniTask DotTask()
    {
        do
        {
            if (thisHealth != null) thisHealth.Damage(_data.OneTickDamage);
            await UniTask.Delay(TimeSpan.FromSeconds(_data.Delay));
        } 
        while (Time.time < startTime + _data.Seconds);
    }
    
    
}