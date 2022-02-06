using Cysharp.Threading.Tasks;
using UnityEngine;

public class SpawnObject : Step
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float scale = 1f;
    [SerializeField] private float destroyAfterSeconds = 5f;

    public override async UniTask Execute()
    {
        GameObject newObject = GameObject.Instantiate(objectToSpawn, ParentTransform);
        newObject.transform.position = ParentTransform.position;
        newObject.transform.localScale *= scale;
        GameObject.Destroy(newObject, destroyAfterSeconds);
    }
}
