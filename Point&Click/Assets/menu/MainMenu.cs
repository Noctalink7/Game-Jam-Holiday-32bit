﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;
    public GameObject settingsWindow;
    public GameObject credits;
    

    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);

    }

    public void SettingsButton()
     {
         settingsWindow.SetActive(true);

     }

      public void CloseSettingsWindow()
      {
         settingsWindow.SetActive(false);
      }  

    public void LanceCredits()
    {
        credits.SetActive(true);
    }

    public void CloseCredits()
    {
        credits.SetActive(false);

    }

     public void QuitGame()
    {
        Application.Quit();
    }

 
}
