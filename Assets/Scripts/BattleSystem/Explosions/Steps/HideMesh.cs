using Cysharp.Threading.Tasks;
using UnityEngine;

public class HideMesh : Step
{
    public override async UniTask Execute()
    {
        MeshRenderer mesh = ParentTransform.gameObject.GetComponent<MeshRenderer>();
        if (mesh != null)
            GameObject.Destroy(mesh);
    }
}
