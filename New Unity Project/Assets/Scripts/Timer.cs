using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI watch;
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
        }
    }

    private void CountingDown()
    {
        timeRemaining--;
        if (timeRemaining > 0)
        {
            Invoke("CountingDown", 1f);
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
}