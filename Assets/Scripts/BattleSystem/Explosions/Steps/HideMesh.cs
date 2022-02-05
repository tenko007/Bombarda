using Cysharp.Threading.Tasks;
using UnityEngine;

public class HideMesh : ExplosionStep
{
    public override async UniTask Execute()
    {
        MeshRenderer mesh = ParentTransform.gameObject.GetComponent<MeshRenderer>();
        if (mesh != null)
            GameObject.Destroy(mesh);
    }
}
