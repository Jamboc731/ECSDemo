using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class SRotation : ComponentSystem
{

    float t;

    struct Rotators
    {
        public Transform Transform;
        public CRotation Rotator;
    }

    protected override void OnUpdate ()
    {

        t = Time.deltaTime;

        foreach (var e in GetEntities<Rotators> ())
        {
            e.Transform.Rotate (e.Transform.up * e.Rotator.GetRotationSpeed () * t);
        }

    }
}
