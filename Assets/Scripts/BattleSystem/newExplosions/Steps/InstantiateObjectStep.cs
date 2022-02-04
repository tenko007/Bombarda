using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/InstantiateObjectStep", fileName = "InstantiateObjectStep")]
    public class InstantiateObjectStep : Step
    {
        [SerializeField] private GameObject objectToInstantiate;
        public override async UniTask Execute() =>
            Instantiate(objectToInstantiate, ParentTransform);
    }
}