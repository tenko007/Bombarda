using UnityEngine;
using Utils.Services;

public class InputManagerTest : MonoBehaviour
{
    private InputSystem _inputSystem;

    private void Start()
    {
        _inputSystem = Services.GetService<InputSystem>();
        _inputSystem.ActionKeys[InputActionType.Fire].SubscribeKeyStart(FireStart);
        _inputSystem.ActionKeys[InputActionType.Fire].SubscribeKeyEnd(FireEnd);
        _inputSystem.ActionKeys[InputActionType.Fire].SubscribeKeyHold(FireHold);
    }
    
    private void OnDestroy()
    {
        _inputSystem.ActionKeys[InputActionType.Fire].UnsubscribeKeyStart(FireStart);
        _inputSystem.ActionKeys[InputActionType.Fire].UnsubscribeKeyEnd(FireEnd);
        _inputSystem.ActionKeys[InputActionType.Fire].UnsubscribeKeyHold(FireHold);
    }

    private void FireStart() => Debug.Log("Fire start");
    private void FireEnd() => Debug.Log("Fire end");
    private void FireHold() => Debug.Log("Fire");
}