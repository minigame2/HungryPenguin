using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icesheet : MonoBehaviour {

    public float speed;
    public int direction;
    public float minPosLeft;
    public float maxPosRight;
    public float padding;
    public float startx;


    // Use this for initialization
    void Start () 
    {
        speed = 1f;
        direction = SetUpDirection();
        minPosLeft = -7.5f;
        maxPosRight = 7.5f;
        padding = 2f;
    }
	
    private int SetUpDirection() 
    {
        if (gameObject.tag == "IcesheetLeft") 
        { 
            return 1;
        }
        else 
        {
            return -1;
        }
    }

    // Update is called once per frame
    void Update () 
    {
        MovePlatform(speed, direction);	
	}

    public void MovePlatform(float mySpeed, int myDirection)
    {
        var deltaX = Time.deltaTime * speed * direction;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, minPosLeft, maxPosRight);
        transform.position = new Vector2(newPosX, transform.position.y);
    }

}
