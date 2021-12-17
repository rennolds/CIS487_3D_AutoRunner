using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailureScreen : MonoBehaviour
{
    public GameObject failMenuUI;
    public MusicHandler reenterTitle;
    public AudioClip title;
    public AudioSource menuSounds;
    public AudioClip menuConfirm, menuBack;

    void Start()
    {
        failMenuUI.SetActive(false);
        reenterTitle = MusicHandler.instance;
    }

    public void FailScreen()
    {
        Time.timeScale = 0f;
        failMenuUI.SetActive(true);
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
