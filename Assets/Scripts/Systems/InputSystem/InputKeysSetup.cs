using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Settings/InputKeys")]
public class InputKeysSetup : ScriptableObject
{
    [SerializeField] private List<KeyBind> _keyCodes;
    public List<KeyBind> KeyCodes => _keyCodes;
}

/*

[Serializable]
public class KeyBind
{
    public KeyBind(InputAction action, KeyCode keyCode)
    {
        this._action = action;
        this.keyKeyCode = keyCode;
    }
    [SerializeField] private InputAction _action;
    [SerializeField] private KeyCode keyKeyCode;
    public InputAction Action => _action;
    public KeyCode KeyKeyCode => keyKeyCode;
    
}
*/

[Serializable]
public class KeyBind
{
    public KeyBind(InputAction action, KeyCode keyCode)
    {
        this.Action = action;
        this.KeyCode = keyCode;
    }
    public InputAction Action;
    public KeyCode KeyCode;
}