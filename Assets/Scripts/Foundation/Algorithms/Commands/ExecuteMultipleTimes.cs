using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/ExecuteMultipleTimes", fileName = "ExecuteMultipleTimes")]
public class ExecuteMultipleTimes : Command
{
    [SerializeField] private Command _command;
    [SerializeField] private int times = 1;
    [SerializeField] private float delay;

    public override async UniTask Execute()
    {
        _command.SetTargetGameObject(TargetGameObject);
        for (int i = 0; i < times; i++)
        {
            await UniTask.Delay(TimeSpan.FromSeconds(delay));
            _command.Execute();
        }
    }
}