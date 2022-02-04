using UnityEngine;

namespace BattleSystem
{
    public interface ISpawner
    {
        GameObject Prefab { get; }
        Vector3 SpawnPosition { get; }
        void Spawn();
    }
}