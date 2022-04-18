using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject MainMenuUI;
    public GameObject LevelMenuUI;

    public void QuitGame()
    {

        Application.Quit();

    }

    public void Play()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void LevelSelect()
    {

        LevelMenuUI.SetActive(true);
        MainMenuUI.SetActive(false);

    }

    public void Back()
    {

        LevelMenuUI.SetActive(false);
        MainMenuUI.SetActive(true);

    }

    public void L1()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    } 
    
    public void L2()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

    public void L3()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }
}
