using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelContorller : MonoBehaviour
{

    [SerializeField] string _nextLevelName;

    Monster[] _monsters;

    void OnEnable()
    {

        _monsters = FindObjectsOfType<Monster>();

    }

    // Update is called once per frame
    void Update()
    {

        if (MonstersAreAllDead())
            GoToNextLevel();

    }

    void GoToNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    bool MonstersAreAllDead()
    {
        
        foreach (var monster in _monsters)
        {

            if (monster.gameObject.activeSelf)
                return false;

        }

        return true;

    }
}
