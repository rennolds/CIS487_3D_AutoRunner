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
    public AudioSource menuSounds;
    public AudioClip menuConfirm, menuBack;

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
        menuSounds.PlayOneShot(menuConfirm);
        if (reenterTitle.levelCount < _CURRENT_HIGHEST_LEVEL_)
        {
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
        menuSounds.PlayOneShot(menuConfirm);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void ReturnToMainMenu()
    {
        menuSounds.PlayOneShot(menuBack);
        reenterTitle.TitleMusic(title);
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }
}