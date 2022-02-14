using System;
using UnityEngine;

public class InputActionKey : IInputActionKey
{
    private KeyCode _keyCode;
    public KeyCode KeyCode => _keyCode;
    public Action OnKeyStart { get; private set; }
    public Action OnKeyHold { get; private set; }
    public Action OnKeyEnd { get; private set; }
    
    public InputActionKey(KeyCode keyCode) => this._keyCode = keyCode;
    public void SubscribeKeyStart(Action action) => OnKeyStart += action;
    public void SubscribeKeyHold(Action action) => OnKeyHold += action;
    public void SubscribeKeyEnd(Action action) => OnKeyEnd += action;
    public void UnsubscribeKeyStart(Action action) => OnKeyStart -= action;
    public void UnsubscribeKeyHold(Action action) => OnKeyHold -= action;
    public void UnsubscribeKeyEnd(Action action) => OnKeyEnd -= action;
    

    public void Update()
    {
        if (Input.GetKeyDown(_keyCode)) OnKeyStart?.Invoke();
        if (Input.GetKey(_keyCode)) OnKeyHold?.Invoke();
        if (Input.GetKeyUp(_keyCode)) OnKeyEnd?.Invoke();
    }
}