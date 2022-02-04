using BattleSystem.newExplosions;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class SpawnExplosion : ExplosionStep
{
    [SerializeField] private Explosion explosion;
    public override async UniTask Execute()
    {
        explosion.SetParentTransform(ParentTransform);
        await explosion.Explode();
    }
}
