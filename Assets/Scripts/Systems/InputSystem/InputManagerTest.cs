using UnityEngine;
using Utils.Services;

public class InputManagerTest : MonoBehaviour
{
    private InputSystem _inputSystem;

    private void Start()
    {
        _inputSystem = Services.GetService<InputSystem>();
        _inputSystem.ActionKeys[InputAction.Fire].SubscribeKeyStart(FireStart);
        _inputSystem.ActionKeys[InputAction.Fire].SubscribeKeyEnd(FireEnd);
        _inputSystem.ActionKeys[InputAction.Fire].SubscribeKeyHold(FireHold);
    }
    
    private void OnDestroy()
    {
        _inputSystem.ActionKeys[InputAction.Fire].UnsubscribeKeyStart(FireStart);
        _inputSystem.ActionKeys[InputAction.Fire].UnsubscribeKeyEnd(FireEnd);
        _inputSystem.ActionKeys[InputAction.Fire].UnsubscribeKeyHold(FireHold);
    }

    private void FireStart() => Debug.Log("Fire start");
    private void FireEnd() => Debug.Log("Fire end");
    private void FireHold() => Debug.Log("Fire");
}