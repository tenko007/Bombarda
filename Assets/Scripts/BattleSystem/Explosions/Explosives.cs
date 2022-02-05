using System;
using BattleSystem.newExplosions;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Explosives : MonoBehaviour // TODO Remove
{
    [SerializeField] private Explosion _explosion;
    [SerializeField] private float destroyDelay = 5f;

    private void Start()
    {
        _explosion.SetParentTransform(transform);
        Explode();
    }

    private async UniTask Explode()
    {
        await _explosion.Explode();
        await UniTask.Delay(TimeSpan.FromSeconds(destroyDelay));
        
        try { Destroy(this.gameObject); } catch { }
    }
}