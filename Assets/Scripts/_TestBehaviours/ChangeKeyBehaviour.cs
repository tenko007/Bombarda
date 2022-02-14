using UnityEngine;

public class ChangeKeyBehaviour : MonoBehaviour
{
    private async void OnGUI()
    {
        GUILayout.Space(300);

        if (GUILayout.Button("Change Fire Button"))
        {
            GUILayout.Label("Press button");
            InputKeySettingsController.Instance.StartChangingInputKey(InputActionType.Fire);
        }
    }
}
