using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    public class Explosives : MonoBehaviour
    {
        [SerializeField] private Explosion _explosion;
        [SerializeField] private float destroyDelay = 5f;

        private void Start()
        {
            _explosion.SetParentTransform(transform);
            Explode();
        }

        private async UniTask Explode()
        {
            await _explosion.Explode();
            await UniTask.Delay(TimeSpan.FromSeconds(destroyDelay));
            Destroy(this.gameObject);
        }
    }
}