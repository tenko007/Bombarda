using Cysharp.Threading.Tasks;
using UnityEngine;

public class SpawnObject : ExplosionStep
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float destroyAfterSeconds = 5f;

    public override async UniTask Execute() =>
        GameObject.Destroy( 
            GameObject.Instantiate(objectToSpawn, ParentTransform), destroyAfterSeconds);
}
