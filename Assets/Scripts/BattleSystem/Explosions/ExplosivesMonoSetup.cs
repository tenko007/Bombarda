using System;
using BattleSystem.newExplosions;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

public class ExplosivesMonoSetup : SerializedMonoBehaviour
{
    [SerializeField] private IExplosion _explosion;
    [SerializeField] private float destroyDelay = 5f;

    private void Start()
    {
        Explode();
    }

    private async UniTask Explode()
    {
        await _explosion.Explode();
        await UniTask.Delay(TimeSpan.FromSeconds(destroyDelay));
        Destroy(this.gameObject);
    }
}