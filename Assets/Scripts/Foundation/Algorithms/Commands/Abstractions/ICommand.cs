using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.Explosions.Steps.Abstractions
{
    public interface ICommand
    {
        UniTask Execute();
        public GameObject TargetGameObject { get; }
        public void SetTargetGameObject(GameObject gameObject);
    }
}