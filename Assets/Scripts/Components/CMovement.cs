using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMovement : MonoBehaviour {

    float moveSpeed = 10f;

    public Vector3 moveDirection;

	void Start ()
    {
        moveDirection = Vector3.forward * moveSpeed;
	}
	
	void Update () {
		
	}

    public void ChangeSpeed (float newSpeed)
    {
        moveSpeed = newSpeed;
        moveDirection = Vector3.forward * moveSpeed;
    }

    public float GetSpeed ()
    {
        return moveSpeed;
    }

}
