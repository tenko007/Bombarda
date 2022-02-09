using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class AlgorithmMonoExecutor : MonoBehaviour
{
    [SerializeField] private Algorithm _algorithm;
    [SerializeField] private float destroyDelay = 5f;

    private void Start()
    {
        _algorithm.SetParentTransform(this.transform);
        Explode();
    }

    private async UniTask Explode()
    {
        _algorithm.SetParentTransform(this.transform);
        await _algorithm.Execute();
        
        await UniTask.Delay(TimeSpan.FromSeconds(destroyDelay));
        try { Destroy(this.gameObject); } catch { }
    }
}