using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class SPatrol : ComponentSystem
{

    Vector3 current;
    Vector3 dir;
    float t;

    struct Patrollers
    {
        public CPatrolling patrol;
        public Transform Transform;
    }

    protected override void OnUpdate ()
    {

        t = Time.deltaTime;
        
        foreach(var e in GetEntities<Patrollers> ())
        {
            current = e.patrol.GetCurrent ();
            if(current == null)
            {
                e.patrol.SelectPoint ();
                current = e.patrol.GetCurrent ();
                DirectionToPoint (e.Transform.position, current);
            }
            else if(Vector3.Distance (e.Transform.position, current) <= 0.5f)
            {
                e.patrol.SelectPoint ();
                current = e.patrol.GetCurrent ();

            }

            dir = DirectionToPoint (e.Transform.position, current);
            Debug.Log (current);
            e.Transform.Translate (dir * 5 * t);

        }

    }

    Vector3 DirectionToPoint (Vector3 ent, Vector3 targ)
    {
        return -(ent - targ);

    }

}
