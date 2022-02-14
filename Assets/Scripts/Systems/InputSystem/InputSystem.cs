using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Utils.Services;
using Utils.UpdateSystem;

public class InputSystem : IInputSystem
{
    private Dictionary<InputAction, IInputActionKey> _actionKeys;
    public Dictionary<InputAction, IInputActionKey> ActionKeys => _actionKeys;
    private InputKeysSetup _inputKeysSetup;

    public InputSystem(InputKeysSetup inputKeysSetup)
    {
        this._inputKeysSetup = inputKeysSetup;
        Start();
    }
    private void Start()
    {
        _actionKeys = new Dictionary<InputAction, IInputActionKey>();
        UploadSetup();
        IUpdateSystem updateManager = Services.GetService<IUpdateSystem>();
        foreach (var inputActionKey in _actionKeys)
            updateManager.Add(inputActionKey.Value);
    }

    private void UploadSetup()
    {
        foreach (var keyCode in _inputKeysSetup.KeyCodes)
            _actionKeys.Add(keyCode.Action, new InputActionKey(keyCode.KeyCode));
    }

    public void ChangeKey(InputAction action, KeyCode newKey)
    {
        var keyBind = _inputKeysSetup.KeyCodes.FirstOrDefault(item => item.Action == action);
        if (keyBind != null)
            keyBind.KeyCode = newKey;
        else
            _inputKeysSetup.KeyCodes.Add(new KeyBind(action, newKey));
        
        if (_actionKeys.ContainsKey(action))
            _actionKeys[action] = new InputActionKey(newKey);
        else
            _actionKeys.Add(action, new InputActionKey(newKey));
    }
    
    public void RemoveKey(InputAction action)
    {
        var keyBind = _inputKeysSetup.KeyCodes.FirstOrDefault(item => item.Action == action);
        _inputKeysSetup.KeyCodes.Remove(keyBind);
        
        if (_actionKeys.ContainsKey(action))
            _actionKeys.Remove(action);
    }
}