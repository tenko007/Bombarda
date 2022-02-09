using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Algorithm")]
public class Algorithm : Command, IAlgorithm
{
    public List<Command> steps;
    public override async UniTask Execute()
    {
        if (steps.Count == 0) return;
        foreach (var step in steps)
        {
            step.SetParentTransform(ParentTransform);
            await step.Execute();
        }
    }
}