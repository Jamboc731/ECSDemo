using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRotation : MonoBehaviour
{

    float rotSpeed = 60;

    public float GetRotationSpeed ()
    {
        return rotSpeed;
    }

    public void SetRotationSpeed(float newSpeed)
    {
        rotSpeed = newSpeed;
    }

}
