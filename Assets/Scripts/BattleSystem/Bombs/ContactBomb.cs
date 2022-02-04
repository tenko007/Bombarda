using UnityEngine;

public class ContactBomb : Bomb
{
    void OnCollisionEnter(Collision collision) => Explode();
}