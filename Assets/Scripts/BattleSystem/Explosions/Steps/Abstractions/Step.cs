using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [Serializable]
    public class Step : SerializedScriptableObject, IStep
    {
        private Transform parentTransform;
        public Transform ParentTransform => parentTransform;
        
        public void SetParentTransform(Transform transform) => 
            parentTransform = transform;
        public virtual async UniTask Execute() {}
    }
}