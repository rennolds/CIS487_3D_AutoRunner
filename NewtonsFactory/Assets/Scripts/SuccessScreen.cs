using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccessScreen : MonoBehaviour
{
    public GameObject winMenuUI;

    void Start()
    {
        winMenuUI.SetActive(false);

    }

    public void WinScreen()
    {
        Time.timeScale = 0f;
        winMenuUI.SetActive(true);
    }

    public void NextLevel()
    {
        //SceneManager.LoadScene();     //Configure how to set up the scene, probably something along the lines of "Level" + some global int
        Time.timeScale = 1f;
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
    }
}