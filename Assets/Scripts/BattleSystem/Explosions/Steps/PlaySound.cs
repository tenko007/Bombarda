using Cysharp.Threading.Tasks;
using UnityEngine;

public class PlaySound : ExplosionStep
{
    [SerializeField] private AudioClip sound;
    [SerializeField] private float volume;
    public override async UniTask Execute()
    {
        AudioSource source = ParentTransform.GetComponent<AudioSource>();
        if (source == null)
            source = ParentTransform.gameObject.AddComponent<AudioSource>();
        source.PlayOneShot(sound, volume); // TODO Adjust the volume by settings OR play with AudioManager
    }
}
