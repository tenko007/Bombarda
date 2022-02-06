using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.Explosions.Steps.Abstractions
{
    public interface IStep
    {
        UniTask Execute();
        public Transform ParentTransform { get; }
        public void SetParentTransform(Transform transform);
    }
}