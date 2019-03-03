using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameRate : MonoBehaviour {

    Text t;

    private void Start ()
    {
        t = GetComponent<Text> ();
    }

    private void Update ()
    {
        t.text = Mathf.Round(1 / Time.deltaTime).ToString ();
    }

}
