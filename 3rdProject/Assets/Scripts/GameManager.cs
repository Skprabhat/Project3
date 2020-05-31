using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public Transform player;
    public Transform scorept;
    int playerScore;
    public GameObject panel;
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //score();
        //checking gameover
        if (Time.timeScale == 1)
        {
            panel.SetActive(false);
        }
    }
    //void score()
    //{
    //    playerScore = (int)Vector3.Distance(player.position, scorept.position);
    //}
    public void GameOver()
    {
        StartCoroutine(delayStart());
    }
    IEnumerator delayStart()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
