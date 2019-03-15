using UnityEngine;
using UnityEngine.UI;

public class DisplayStates : MonoBehaviour
{
    public Text timerText;
    public Text scoreText;
    public DataContainer dataContainer;

    private void Start ()
    {
        timerText.text = dataContainer.GetTimerText ();
        scoreText.text = dataContainer.GetScoreText ();
    }

    private void Update()
    {
        timerText.text = dataContainer.GetTimerText();
        scoreText.text = dataContainer.GetScoreText();
    }

}
