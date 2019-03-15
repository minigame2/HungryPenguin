using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string AXISHORIZONTAL = "Horizontal";

    public float moveSpeed = 6f;
    public float xMin = -8.0f, xMax = 8.0f;


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);

        transform.position = new Vector2(newPosX, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "ColliderBottom" && gameObject.tag == "Player")
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
        else if(collision.name == "ColliderTop" && gameObject.tag == "Player")
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
    }
}


