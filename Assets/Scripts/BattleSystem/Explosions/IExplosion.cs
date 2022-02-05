using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    public interface IExplosion
    {
        UniTask Explode();
        public void SetParentTransform(Transform transform);
    }
}