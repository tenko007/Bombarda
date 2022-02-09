﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SmartSphereDamage : SphereDamage
{
    protected override List<Collider> FindAllCollidersNearby()
    {
        var colliders = base.FindAllCollidersNearby();
        foreach (var collider in colliders.ToList())
            if (!isVisible(collider))
                colliders.Remove(collider);
        
        return colliders;
    }
    
    public bool isVisible(Collider collider)
    {
        var position = ParentTransform.position;
        var colliderPosition = collider.transform.position;
        
        Ray ray = new Ray(position, (colliderPosition - position));
        Physics.Raycast(ray, out var hit);
        return hit.collider == collider;
    }
}