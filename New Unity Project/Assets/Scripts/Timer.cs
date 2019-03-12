using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI watch;
    private float timer;
    private int interval = 10;
    public const int duration = 60;
    public int timeRemaining;
    public bool isCountingDown = false;

    public void StartCountDown()
    {
        if (!isCountingDown)
        {
            isCountingDown = true;
            timeRemaining = duration;
            Invoke("CountingDown", 1f);
            Debug.Log("CountingDown");
        }
    }

    private void CountingDown()
    {
        timeRemaining--;
        if (timeRemaining > 0)
        {
            Invoke("CountingDown", 1f);
            Debug.Log("Invoke" + timeRemaining);
            watch.text = "" +timeRemaining.ToString("00:00");
        }
        else
        {
            isCountingDown = false;
        }
    }


   
    // Use this for initialization
    void Start()
    {
        StartCountDown();
        watch = gameObject.GetComponent<TextMeshProUGUI>();
        watch.text = "01:00";
    }

    //private void Update()
    //{
    //    CountingDown();
    //    Debug.Log("UpdateCountDown" + timeRemaining);
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    timer += Time.deltaTime;
    //    watch.text = string.Format("{0:00}:{1:00}",
    //        Mathf.Floor(timer / 60),
    //        Mathf.Floor(timer) % 60);
    //    Debug.Log("Timer" + timer);

    //    if (timer > interval)
    //    {
    //        //GlobalVariables.speed = GlobalVariables.speed - 1f;
    //        interval = interval - 10;
    //        Debug.Log("Interval" + interval);
    //    }
    //}
}