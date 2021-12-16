using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string firstLevel;

    public string optionsMenu;

    public string howToPlayMenu;

    public string startMenu;

    string currScene;

    public MusicHandler overallMusic;

    // Start is called before the first frame update
    void Start()
    {
        currScene = SceneManager.GetActiveScene().name;
        overallMusic = MusicHandler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame(AudioClip def)
    {
        if (overallMusic.chosenSong == null)
            overallMusic.chosenSong = def;
        overallMusic.ReloadOnLevel();
        overallMusic.levelCount++;
        SceneManager.LoadScene("Skybox");
    }

    public void openHowToPlay()
    {
        SceneManager.LoadScene(howToPlayMenu);
    }

    public void openOptions()
    {
        SceneManager.LoadScene(optionsMenu);
    }

    public void closeOptions()
    {
        if (currScene == "OptionsMenu")
            overallMusic.UnPauseMusic();
        SceneManager.LoadScene(startMenu);
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
