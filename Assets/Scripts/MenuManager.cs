using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
        GenerateLevel.gameOver = false;

    }

    public void QuitButon()
    {
        Application.Quit();
    }
}
