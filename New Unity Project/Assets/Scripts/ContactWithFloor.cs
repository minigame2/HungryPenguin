using UnityEngine;
using UnityEngine.UI;

public class ContactWithFloor : MonoBehaviour
{
    private const string TAGPLAYER = "Player";
    private const string TAGFLOOR = "Floor";
 
    public SceneLoader SceneLoader;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TAGPLAYER && gameObject.tag == "Floor")
        {
            SceneLoader.LoadGameOverScene();
        }
    }
}