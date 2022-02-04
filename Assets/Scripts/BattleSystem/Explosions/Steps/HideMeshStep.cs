using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/HideMeshStep", fileName = "HideMeshStep")]
    public class HideMeshStep : Step
    {
        public override async UniTask Execute()
        {
            MeshRenderer mesh = ParentTransform.gameObject.GetComponent<MeshRenderer>();
            if (mesh != null)
                Destroy(mesh);
        }
    }
}