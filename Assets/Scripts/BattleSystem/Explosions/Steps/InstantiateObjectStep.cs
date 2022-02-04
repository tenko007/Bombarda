using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/InstantiateObjectStep", fileName = "InstantiateObjectStep")]
    public class InstantiateObjectStep : Step
    {
        [SerializeField] private GameObject objectToInstantiate;
        [SerializeField] private float destroyAfterSeconds = 5f;

        public override async UniTask Execute() =>
            Destroy(Instantiate(objectToInstantiate, ParentTransform), destroyAfterSeconds);
    }
}