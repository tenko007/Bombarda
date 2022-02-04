using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/DeleteBaseChildsStep", fileName = "DeleteBaseChildsStep")]
    public class DeleteBaseChildsStep : Step
    {
        private Transform[] _transforms;
        [SerializeField] float deleteDelay = 0f;
        public override async UniTask Execute()
        {
            _transforms = ParentTransform.gameObject.GetComponentsInChildren<Transform>();
            DeleteAfter(deleteDelay);
        }
        
        private async UniTask DeleteAfter(float seconds)
        {
            await UniTask.Delay(TimeSpan.FromSeconds(seconds));
            foreach (var transform in _transforms)
            {
                if (transform != ParentTransform)
                    Destroy(transform.gameObject);
            }
        }
    }
}