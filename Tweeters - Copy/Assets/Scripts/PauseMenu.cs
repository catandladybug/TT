using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject volumeMenuUI;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {

                Resume();

            }
            else
            {

                Pause();

            }

        }
    }

   public void Resume ()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause ()
    {
     
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void QuitGame ()
    {

        Application.Quit();

    }

    public void Volume()
    {

        pauseMenuUI.SetActive(false);
        volumeMenuUI.SetActive(true);

    }

    public void Back()
    {

        pauseMenuUI.SetActive(true);
        volumeMenuUI.SetActive(false);

    }

    public void Restart()
    {

        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
