using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/ExplosionStep", fileName = "ExplosionStep")]
    public class ExplosionStep : Step
    {
        [SerializeField] private Explosion explosion;
        public override async UniTask Execute()
        {
            explosion.SetParentTransform(ParentTransform);
            await explosion.Explode();
        }
    }
}