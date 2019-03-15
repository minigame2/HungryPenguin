using UnityEngine;

[CreateAssetMenu(menuName = "NameData")]
public class DataContainer : ScriptableObject {

    [SerializeField]
    string time;
    [SerializeField]
    int score;

    public void AddToScore (int points)
    {
        score += points;
    }

    public void WriteTimer (string timerTime)
    {
        time = timerTime;
    }

    public string GetTimerText ()
    {
        return time;
    }

    public string GetScoreText ()
    {
        return score.ToString ();
    }

    public void ResetData()
    {
        time = "00:00";
        score = 0;
    }
}
