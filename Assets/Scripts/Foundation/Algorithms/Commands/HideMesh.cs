using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/HideMesh", fileName = "HideMesh")]
public class HideMesh : Command
{
    public override async UniTask Execute()
    {
        MeshRenderer mesh = ParentTransform.gameObject.GetComponent<MeshRenderer>();
        if (mesh != null)
            GameObject.Destroy(mesh);
    }
}
