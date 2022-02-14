using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Utils.Services;

public class InputKeySettingsController
{
    private static InputKeySettingsController _instance;
    public static InputKeySettingsController Instance => GetInstance();

    private static InputKeySettingsController GetInstance()
    {
        if (_instance == null) _instance = new InputKeySettingsController();
        return _instance;
    }

    public async void StartChangingInputKey(InputActionType actionType) 
        => await ListenKey(actionType);
    
    private async UniTask ListenKey(InputActionType actionType)
    {
        while (true)
        {
            Debug.Log("Waiting for key");

            if (Input.anyKeyDown)
            {
                foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
                {
                    if (!Input.GetKey(keyCode)) continue;
                    Services.GetService<InputSystem>().ChangeKey(actionType, keyCode);
                    Debug.Log($"New KeyCode is {keyCode.ToString()}");
                    return;
                }
            }
            await UniTask.Yield();
        }
    }
}