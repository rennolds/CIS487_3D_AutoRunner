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

    public AudioSource menuSounds;
    public AudioClip menuConfirm, menuBack;

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

    public void startGame()
    {
        menuSounds.PlayOneShot(menuConfirm);
        overallMusic.ReloadOnLevel();
        overallMusic.levelCount = 1;
        SceneManager.LoadScene("Skybox");
    }

    public void openHowToPlay()
    {
        menuSounds.PlayOneShot(menuConfirm);
        SceneManager.LoadScene(howToPlayMenu);
    }

    public void openOptions()
    {
        menuSounds.PlayOneShot(menuConfirm);
        SceneManager.LoadScene(optionsMenu);
    }

    public void closeOptions()
    {
        menuSounds.PlayOneShot(menuBack);
        if (currScene == "OptionsMenu")
            overallMusic.UnPauseMusic();
        SceneManager.LoadScene(startMenu);
    }

    public void quitGame()
    {
        menuSounds.PlayOneShot(menuBack);
        Application.Quit();
    }

}
