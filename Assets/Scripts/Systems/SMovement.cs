using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class SMovement : ComponentSystem
{

    float t;

    struct Movers
    {

        public Transform Transform;

        public CMovement movement;

    }

    protected override void OnUpdate ()
    {

        t = Time.deltaTime;

        foreach (var e in GetEntities<Movers> ())
        {
            e.Transform.Translate (Vector3.forward * e.movement.GetSpeed() * t);
        }

    }
}
