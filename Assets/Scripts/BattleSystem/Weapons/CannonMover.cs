using System;
using System.Data;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace BattleSystem
{
    public class CannonMover : MonoBehaviour
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
            thisTransform.Rotate(Vector3.up, rotateSpeed * rotationSide);
            if ((thisTransform.rotation.eulerAngles.y < minYAngle) 
                || (thisTransform.rotation.eulerAngles.y > maxYAngle))
                rotationSide *= -1;
        }
    }
}