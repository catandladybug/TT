using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    public void QuitGame()
    {

        Application.Quit();

    }

    public void MainMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);

    }

}
