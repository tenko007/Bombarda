using System;
using UnityEngine;

[Serializable]
public class KeyBind
{
    public KeyBind(InputActionType actionType, KeyCode keyCode)
    {
        this.actionType = actionType;
        this.KeyCode = keyCode;
    }
    public InputActionType actionType;
    public KeyCode KeyCode;
}