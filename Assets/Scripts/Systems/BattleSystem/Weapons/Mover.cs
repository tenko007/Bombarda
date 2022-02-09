using System;
using System.Data;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace BattleSystem
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float minYAngle = -90f;
        [SerializeField] private float maxYAngle = 90f;
        [SerializeField] private float rotateSpeed = 1f;
        
        private Transform thisTransform;
        private short rotationSide = 1;

        private void Start()
        {
            thisTransform = this.transform;
        }

        private void FixedUpdate()
        {
            Rotate();
        }

        private void Rotate()
        {
            // TODO
        }
    }
}