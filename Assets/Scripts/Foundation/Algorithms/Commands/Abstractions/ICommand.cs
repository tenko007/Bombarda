using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.Explosions.Steps.Abstractions
{
    public interface ICommand
    {
        UniTask Execute();
        public Transform ParentTransform { get; }
        public void SetParentTransform(Transform transform);
    }
}