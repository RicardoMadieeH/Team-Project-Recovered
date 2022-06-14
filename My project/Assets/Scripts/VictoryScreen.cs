using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Caves1");
    }

    public void BackToMenuVictory()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGameVictory()
    {
        Application.Quit();
    }

}
