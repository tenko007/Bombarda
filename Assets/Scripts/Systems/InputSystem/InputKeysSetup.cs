using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Settings/InputKeys")]
public class InputKeysSetup : ScriptableObject
{
    [SerializeField] private List<KeyBind> _keyCodes;
    public List<KeyBind> KeyCodes => _keyCodes;

    public bool ChangeBind(InputActionType actionType, KeyCode keyCode)
    {
        if (!ConfirmNewBind(actionType, keyCode))
            return false;
        
        var keyBind = KeyCodes.FirstOrDefault(item => item.actionType == actionType);
        if (keyBind != null) keyBind.KeyCode = keyCode;
        else KeyCodes.Add(new KeyBind(actionType, keyCode));
        
        return true;
    }
    public void RemoveBind(InputActionType actionType)
    {
        var keyBind = KeyCodes.FirstOrDefault(item => item.actionType == actionType);
        if (keyBind != null) KeyCodes.Remove(keyBind);
    }

    private bool ConfirmNewBind(InputActionType actionType, KeyCode keyCode)
    {
        if (keyCode == KeyCode.None) return true;
        
        var currentKeyBind = KeyCodes.FirstOrDefault(item => item.KeyCode == keyCode && item.actionType != actionType);
        if (currentKeyBind == null) return true;
        
        Debug.LogWarning($"The KeyCode {keyCode.ToString()} is already assigned to the action {currentKeyBind.actionType.ToString()}");
        return false;
    }
}