using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOrientationToCamera : MonoBehaviour
{
    private Transform mainCameraTransform;
    private Transform thisTransform;

    void Start()
    {
        mainCameraTransform = Camera.main.transform;
        thisTransform = this.transform;
    } 

    void Update()
    {
        thisTransform.rotation = mainCameraTransform.rotation;
    }
}
