using System;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

public class AlgorithmMonoExecutor : SerializedMonoBehaviour
{
    [SerializeField] private IAlgorithm _algorithm;
    [SerializeField] private float destroyDelay = 5f;

    private void Start()
    {
        _algorithm.SetParentTransform(this.transform);
        Explode();
    }

    private async UniTask Explode()
    {
        await _algorithm.Explode();
        await UniTask.Delay(TimeSpan.FromSeconds(destroyDelay));
        
        try { Destroy(this.gameObject); } catch { }
    }
}