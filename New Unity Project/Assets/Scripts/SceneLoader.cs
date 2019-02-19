using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    enum Scenes { IntroScreen, PlayScreen, GameOverScreen, WonScreen };

    public void LoadIntroScene()
    {
        SceneManager.LoadScene((int)Scenes.IntroScreen);
    }

    public void LoadPlayScreen()
    {
        SceneManager.LoadScene((int)Scenes.PlayScreen);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene((int)Scenes.GameOverScreen);
    }

    public void LoadWonScene()
    {
        SceneManager.LoadScene((int)Scenes.WonScreen);
    }
}