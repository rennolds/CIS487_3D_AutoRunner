using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccessScreen : MonoBehaviour
{
    public GameObject winMenuUI;
    public MusicHandler reenterTitle;
    public AudioClip title;
    public int _CURRENT_HIGHEST_LEVEL_ = 3;

    void Start()
    {
        winMenuUI.SetActive(false);
        reenterTitle = MusicHandler.instance;

    }

    public void WinScreen()
    {
        Time.timeScale = 0f;
        winMenuUI.SetActive(true);
    }

    public void NextLevel()
    {
        if (reenterTitle.levelCount < _CURRENT_HIGHEST_LEVEL_)
        {
            //SceneManager.LoadScene();     //Configure how to set up the scene, probably something along the lines of "Level" + some global int
            reenterTitle.levelCount++;
            SceneManager.LoadScene("Level0" + reenterTitle.levelCount);
        }
        else
        {
            reenterTitle.TitleMusic(title);
            SceneManager.LoadScene("StartMenu");
        }
        Time.timeScale = 1f;
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void ReturnToMainMenu()
    {
        reenterTitle.TitleMusic(title);
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }
}