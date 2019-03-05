using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPatrolling : MonoBehaviour {

    Transform patrolParent;
    List<Vector3> patrols = new List<Vector3>();
    Vector3 current;

    private void Start ()
    {
        patrolParent = GameObject.Find ("Patrols").transform;

        foreach (Transform t in patrolParent)
        {
            patrols.Add (t.position);
        }
    }

    public void SelectPoint ()
    {

        current = patrols [Random.Range (0, patrols.Count)];

    }

    public Vector3 GetCurrent ()
    {
        return current;
    }

}
