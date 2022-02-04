using UnityEngine;

public class AudioManager : IAudioManager
{
    [SerializeField] private AudioSource source;
    [SerializeField] private float globalSoundVolume;
    [SerializeField] private float globalMusicVolume;

    public float GlobalSoundVolume => globalSoundVolume;
    public float GlobalMusicVolume => globalMusicVolume;
    
    public void PlaySound(AudioClip sound, float volume) =>
        Play(sound, volume * globalSoundVolume);
    
    public void PlayMusic(AudioClip music, float volume) =>
        Play(music, volume * globalMusicVolume);

    private void Play(AudioClip clip, float volume)
    {
        source.PlayOneShot(clip, volume);
    }
}