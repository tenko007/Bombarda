using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleSystem
{
    public class Cannon : MonoBehaviour
    {
        [SerializeField] private float cooldown;
        [SerializeField] private GameObject bomb;
        [SerializeField] private GameObject aimPoint;
        [SerializeField] private float forceCoefficient = 1f;
        
        private Transform thisTransform;
        private Vector3 aimPosition;
        private void Start()
        {
            thisTransform = this.transform;
            aimPosition = aimPoint.transform.position;
            StartCoroutine(Shoting());
        }

        private void OnDestroy()
        {
            StopAllCoroutines();
        }

        private void ShotBomb()
        {
            var newBomb = Instantiate(bomb, aimPosition, Quaternion.identity);
            Rigidbody rigidbody = newBomb.GetComponent<Rigidbody>();
            Vector3 force = thisTransform.forward;
            rigidbody.AddForce(force * forceCoefficient, ForceMode.Impulse);
        }

        public IEnumerator Shoting()
        {
            while (true)
            {
                yield return new WaitForSeconds(cooldown);
                ShotBomb();
            }
        }
    }
}