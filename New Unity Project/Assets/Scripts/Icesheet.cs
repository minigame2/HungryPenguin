using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icesheet : MonoBehaviour {

    public float speed;
    public int direction;
    public float minPosLeft;
    public float maxPosRight;
    public float padding;


    // Use this for initialization
    void Start () 
    {
        speed = 1f;
        direction = 1;
        minPosLeft = -7.5f;
        maxPosRight = 7.5f;
        padding = 2f;
    }
	
	// Update is called once per frame
	void Update () {
        MovePlatform(speed, direction);	
	}

    public void MovePlatform (float mySpeed, int myDirection)
    {
        Debug.Log("MovePlatform");
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, minPosLeft, maxPosRight);

        transform.position = new Vector2(newPosX, transform.position.y);
    }
}
