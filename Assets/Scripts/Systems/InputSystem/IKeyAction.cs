using System;
using UnityEngine;
using Utils.UpdateSystem;

public interface IKeyAction : IUpdatable
{
    public KeyCode KeyCode { get; }
    public Action OnKeyStart { get; }
    public Action OnKeyHold { get; }
    public Action OnKeyEnd { get; }

    public void SubscribeKeyStart(Action action);
    public void SubscribeKeyHold(Action action);
    public void SubscribeKeyEnd(Action action);
    
    public void UnsubscribeKeyStart(Action action);
    public void UnsubscribeKeyHold(Action action);
    public void UnsubscribeKeyEnd(Action action);


}