using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject PausePanel;
    public bool isPause;
    private GameTimer gameTimer;      // Reference to the GameTimer script

    private void Start()
    {
        PausePanel.SetActive(false);
        gameTimer = FindObjectOfType<GameTimer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            if (isPause)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
        gameTimer.StopTimer(); // Stop the timer when paused
    }


    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }

    //Calling from Player life script
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game play 2");
    }


    public void Quit()
    {
        // This function quits the application.
        Application.Quit();
    }


    public void EndGame()
    {
        gameTimer.StopTimer(); // Stop the timer
        gameTimer.SaveElapsedTime(); // Save the elapsed time
        Time.timeScale = 0f;
        SceneManager.LoadScene("EndScreen"); // Load the end screen scene
    }

}
