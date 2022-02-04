using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/PlaySoundStep", fileName = "PlaySoundStep")]
    public class PlaySoundStep : Step
    {
        [SerializeField] private AudioClip sound;
        [SerializeField] private float volume;
        public override async UniTask Execute()
        {
            GameObject newGameObject = new GameObject();
            newGameObject.transform.SetParent(ParentTransform);
            AudioSource source = newGameObject.AddComponent<AudioSource>();
            source.PlayOneShot(sound, volume);
        }
    }
}