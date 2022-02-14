using System;
using UnityEngine;

public class KeyAction : IKeyAction
{
    public KeyCode KeyCode { get; set; }
    
    public Action OnKeyStart { get; private set; }
    public Action OnKeyHold { get; private set; }
    public Action OnKeyEnd { get; private set; }
    
    public KeyAction(KeyCode keyCode) => this.KeyCode = keyCode;
    
    public void SubscribeKeyStart(Action action) => OnKeyStart += action;
    public void SubscribeKeyHold(Action action) => OnKeyHold += action;
    public void SubscribeKeyEnd(Action action) => OnKeyEnd += action;
    
    public void UnsubscribeKeyStart(Action action) => OnKeyStart -= action;
    public void UnsubscribeKeyHold(Action action) => OnKeyHold -= action;
    public void UnsubscribeKeyEnd(Action action) => OnKeyEnd -= action;
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode)) OnKeyStart?.Invoke();
        if (Input.GetKey(KeyCode)) OnKeyHold?.Invoke();
        if (Input.GetKeyUp(KeyCode)) OnKeyEnd?.Invoke();
    }
}