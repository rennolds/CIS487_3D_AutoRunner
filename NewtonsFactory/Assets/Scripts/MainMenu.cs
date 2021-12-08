using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string firstLevel;

    public string optionsMenu;

    public string startMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void startGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void openOptions()
    {
        SceneManager.LoadScene(optionsMenu);
    }

    public void closeOptions()
    {
        SceneManager.LoadScene(startMenu);
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
