using System;
using System.Collections;
using UnityEngine;

public class BombWithTimer : Bomb
{
    [SerializeField] private float timeToExplode;
    private void Start()
    {
        StartCoroutine(WaitForExplode(timeToExplode));
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    IEnumerator WaitForExplode(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Explode();
    }
}