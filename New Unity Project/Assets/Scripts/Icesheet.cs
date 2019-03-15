using UnityEngine;

public class Icesheet : MonoBehaviour {

    private const string ICESHEETLEFT = "IcesheetLeft";

    public GameObject fish;

    public float speed;
    public int direction;
    public float minPosLeft;
    public float maxPosRight;
    public float minPosBottom;
    public float maxPosTop;
    public float padding;
    public float startx;
    public float fishPosX, fishPosY;

    private void Start () 
    {
        speed = 1f;
        direction = SetUpDirection();
        minPosLeft = -13.0f;
        maxPosRight = 13.0f;
        padding = 2.0f;
        fishPosX = 0.0f;
        fishPosY = 2.4f;

        RandomInstantiateFishOnSheet();
      // InstantiateFischOnSheet(GetFishPosition());
      // Debug.Log("after fish instantiate: " + this.transform.position);
    }

    private void RandomInstantiateFishOnSheet()
    {
        float rand = Random.Range(1, 5);
        Debug.Log("RAND: "+rand);
        if (rand > 2)
        {
            InstantiateFischOnSheet(GetFishPosition());
        }

        
    }
   private void Update ()
    {
        if (gameObject.tag == "IcesheetUnderground")
        {
            MovePlatformToSky (speed, direction);
            return;
        }

        MovePlatform (speed, direction);
    }

    private Vector2 GetFishPosition ()
    {
        return new Vector2 (fishPosX, fishPosY);
    }

    private int SetUpDirection() 
    {
        int tmpDir = -1;
        
        if (gameObject.tag == ICESHEETLEFT) 
        { 
            tmpDir =  1;
        }

        return tmpDir;
    }

    public void MovePlatform(float mySpeed, int myDirection)
    {
        var deltaX = Time.deltaTime * speed * direction;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, minPosLeft, maxPosRight);
        transform.position = new Vector2(newPosX, transform.position.y);
    }


    public void MovePlatformToSky(float mySpeed, int myDirection)
    {
        var deltaY = Time.deltaTime * speed;
        var newPosY = Mathf.Clamp(transform.position.y + deltaY, minPosBottom, maxPosTop);
        Debug.Log(newPosY);
        transform.position = new Vector2(transform.position.x, newPosY);
    }

    public void InstantiateFischOnSheet(Vector2 icesheetPos)
    {
        Debug.Log("Instanziate transform" + this.transform.position);
        GameObject go = Instantiate(fish, new Vector3(0.0f,0.0f,0.0f), Quaternion.identity,this.transform);
        go.gameObject.transform.localPosition = GetFishPosition();
        Debug.Log("transform of GO: " + go.transform.position);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision: " + gameObject.name + "" + collision.gameObject.name);
        if (gameObject.name == "IcesheetBottom" && collision.name == "ColliderTop" )
        {
            Destroy(gameObject);
        }
        else if(gameObject.name == "IcesheetLeft" && collision.name == "ColliderRight")
        {
            Destroy(gameObject);
        }
        else if(gameObject.name == "IcesheetRight" && collision.name == "ColliderLeft")
        {
            Destroy(gameObject);
        }
    }
}
