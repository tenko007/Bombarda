using UnityEngine;
using Utils.Services;
using Utils.UpdateSystem;

public class GameBootstrap : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private InputKeysSetup _inputKeysSetup;

    //[Header("Sounds")] 
    //[Header("GameObjects")] 
    //[Header("Data")]

    private void Awake()
    {
        Services.SetServiceLocator(new ServiceLocator());

        SetupVariables();
        RegisterServices();
        SetupUtils();
    }

    private void SetupVariables()
    {
    }

    private void RegisterServices()
    {
        Services.RegisterService<IUpdateSystem>(Instantiate(new GameObject().AddComponent<UpdateSystem>(), this.transform));
        Services.RegisterService<InputSystem>(new InputSystem(_inputKeysSetup));
    }
    
    private void SetupUtils()
    {
    }
}