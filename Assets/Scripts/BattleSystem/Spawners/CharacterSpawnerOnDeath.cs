using System;
using UnityEngine;

namespace BattleSystem
{
    public class CharacterSpawnerOnDeath : MonoBehaviour, ISpawner
    {
        [SerializeField] private GameObject characterPrefab;

        public GameObject Prefab => characterPrefab;
        public Vector3 SpawnPosition => thisPosition;
        
        private Vector3 thisPosition;
        private Transform thisTransform;
        private Health currentCharacterHealth;

        private void Start()
        {
            thisTransform = this.transform;
            thisPosition = thisTransform.position;
            Spawn();
        }
        
        public void Spawn()
        {
            if (currentCharacterHealth != null)
                currentCharacterHealth.OnZeroHealth -= Spawn;
            
            Health newCurrentCharacterHealth = Instantiate(characterPrefab, SpawnPosition, Quaternion.identity, thisTransform).GetComponent<Health>();
            if (newCurrentCharacterHealth != null)
                newCurrentCharacterHealth.OnZeroHealth += Spawn;
            
            currentCharacterHealth = newCurrentCharacterHealth;
        }
    }
}