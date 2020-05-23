using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public void pause()
    {
        GameManager.instance.pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void startGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void resumeGame()
    {
        Time.timeScale = 1;
        GameManager.instance.pausePanel.SetActive(false);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
