using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/SpawnObject", fileName = "SpawnObject")]
public class SpawnObject : Command
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float scale = 1f;
    [SerializeField] private float destroyAfterSeconds = 5f;

    public override async UniTask Execute()
    {
        GameObject newObject = GameObject.Instantiate(objectToSpawn, TargetGameObject.transform);
        newObject.transform.localScale *= scale;
        GameObject.Destroy(newObject, destroyAfterSeconds);
    }
}