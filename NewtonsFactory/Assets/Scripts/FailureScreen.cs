using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailureScreen : MonoBehaviour
{
    public GameObject failMenuUI;

    void Start()
    {
        failMenuUI.SetActive(false);

    }

    public void FailScreen()
    {
        Time.timeScale = 0f;
        failMenuUI.SetActive(true);
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }
}
