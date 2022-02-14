using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Utils.Services;
using Utils.UpdateSystem;

public class InputSystem : IInputSystem
{
    private Dictionary<InputActionType, KeyAction> _actionKeys;
    public Dictionary<InputActionType, KeyAction> ActionKeys => _actionKeys;
    private InputKeysSetup _inputKeysSetup;
    private IUpdateSystem updateSystem;

    public InputSystem(InputKeysSetup inputKeysSetup)
    {
        this._inputKeysSetup = inputKeysSetup;
        Start();
    }
    private void Start()
    {
        _actionKeys = new Dictionary<InputActionType, KeyAction>();
        updateSystem = Services.GetService<IUpdateSystem>();
        
        UploadSetup();
    }
    
    private void UploadSetup()
    {
        foreach (var keyCode in _inputKeysSetup.KeyCodes.ToList())
            AddKey(keyCode.actionType, keyCode.KeyCode);
    }
    
    public void AddKey(InputActionType actionType, KeyCode newKey)
    {
        if (!_inputKeysSetup.ChangeBind(actionType, newKey)) return;

        var newKeyAction = new KeyAction(newKey);
        _actionKeys.Add(actionType, newKeyAction);
        updateSystem.Add(newKeyAction);
    }
    
    public void ChangeKey(InputActionType actionType, KeyCode newKey)
    {
        if (!_inputKeysSetup.ChangeBind(actionType, newKey)) return;
        
        if (_actionKeys.ContainsKey(actionType))
            _actionKeys[actionType].KeyCode = newKey;
        else
            AddKey(actionType, newKey);
    }
    
    public void RemoveKey(InputActionType actionType)
    {
        if (!_actionKeys.ContainsKey(actionType)) return;
            
        updateSystem.Remove(_actionKeys[actionType]);
        _actionKeys.Remove(actionType);
    }
}