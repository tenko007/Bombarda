using UnityEngine;

namespace BattleSystem
{
    public interface ICharacterSpawner
    {
        GameObject CharacterPrefab { get; }
        Vector3 SpawnPosition { get; }
        void Spawn();
    }
}