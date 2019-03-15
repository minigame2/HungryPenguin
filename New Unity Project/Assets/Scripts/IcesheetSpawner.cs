using UnityEngine;

public class IcesheetSpawner : MonoBehaviour
{
    public GameObject icesheetRight;
    public GameObject icesheetLeft;
    public GameObject icesheetBottom;
    
    public GameObject icesheetContainer;
    public GameObject iceSheetPosLeftTop, iceSheetPosRightTop, iceSheetPosLeftBottom, iceSheetPosRightBottom;
    public GameObject iceSheetPosUndergroundRight, icesheetPosUntergroundLeft;

    private float timer = 0f;
    private float delayMin = 3f;
    private float delayMax = 10f;
    private float delay;

    public void SpawnIcesheets()
    {
        SpawnRightIcesheet ();
        SpawnLeftIcesheet ();
        SpawnUndergroundIcesheet ();
    }

    private void SpawnRightIcesheet ()
    {
        Instantiate(icesheetRight, GetRandomInitPosRight(), Quaternion.identity, icesheetContainer.transform);
        Debug.Log("instanciate R");
    }

    private void SpawnLeftIcesheet ()
    {
        Instantiate(icesheetLeft, GetRandomInitPosLeft(), Quaternion.identity, icesheetContainer.transform);
        Debug.Log("instanciate L");
    }

    private void SpawnUndergroundIcesheet ()
    {
        Instantiate(icesheetBottom, GetRandomInitPosUnderground(), Quaternion.identity, icesheetContainer.transform);
        Debug.Log("instanciate UG");
    }

    public Vector2 GetRandomInitPosUnderground ()
    {
        float randomX = Random.Range(iceSheetPosUndergroundRight.transform.position.x, icesheetPosUntergroundLeft.transform.position.x);
        return new Vector2(randomX,iceSheetPosUndergroundRight.transform.position.y);
    }

    public Vector2 GetRandomInitPosLeft ()
    {
        float randomY = Random.Range(iceSheetPosLeftBottom.transform.position.y, iceSheetPosLeftTop.transform.position.y); 
        return new Vector2(iceSheetPosLeftTop.transform.position.x, randomY);
    }

    public Vector2 GetRandomInitPosRight ()
    {
        float randomY = Random.Range(iceSheetPosRightTop.transform.position.y, iceSheetPosRightBottom.transform.position.y);
        return new Vector2(iceSheetPosRightTop.transform.position.x, randomY);
    }

    void Start () {
        delay = delayMin;
	}
	
	void Update () {
        timer += Time.deltaTime;
        
        if(timer > delay)
        {
            float leftOrRight = Random.Range(0f, 2f);
            Debug.Log("leftorright" + leftOrRight);
            if (leftOrRight < 1)
            {
                SpawnLeftIcesheet ();
            }
            else
            {
                SpawnRightIcesheet ();
            }
           
            timer = 0f;
            delay = Random.Range (delayMin, delayMax);
            SpawnUndergroundIcesheet ();
        }
	}


}
