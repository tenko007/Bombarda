using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/PlaySound", fileName = "PlaySound")]
public class PlaySound : Command
{
    [SerializeField] private AudioClip sound;
    [SerializeField] private float volume;
    public override async UniTask Execute()
    {
        AudioSource source = TargetGameObject.GetComponent<AudioSource>();
        if (source == null)
            source = TargetGameObject.AddComponent<AudioSource>();
        source.PlayOneShot(sound, volume); // TODO Adjust the volume by settings OR play with AudioManager
    }
}
