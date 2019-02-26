using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icesheet : MonoBehaviour {

    public float speed;
    public int direction;

	// Use this for initialization
	void Start () 
    {
        speed = 1f;
        direction = 1;
	}
	
	// Update is called once per frame
	void Update () {
        MovePlatform(speed, direction);	
	}

    public void MovePlatform (float mySpeed, int myDirection)
    {
        Debug.Log("MovePlatform");
    }
}
