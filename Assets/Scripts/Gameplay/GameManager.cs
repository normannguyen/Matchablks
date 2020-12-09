﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool pausedGame;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausedGame)
            {
                Unpause();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        pausedGame = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;

    }
    //Unpause
    public void Unpause()
    {
        pausedGame = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

    }
}
