using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicHandler : MonoBehaviour
{
    public static MusicHandler instance;
    AudioSource _backgroundMusic, _sampleMusic;
    public AudioClip chosenSong;
    bool isPause = false;
    public int levelCount = 0;

    void Awake()
    {
        MakeSingleton();
        _backgroundMusic = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void ReloadOnLevel()
    {
        _backgroundMusic.clip = chosenSong;
        _backgroundMusic.Play();
    }

    public void PauseMusic()
    {
        _backgroundMusic.Pause();
    }

    public void UnPauseMusic()
    {
        _backgroundMusic.UnPause();
    }


    //public void playThisSample(AudioClip selected)
    //{
    //    if (!isPause)
    //    {
    //        _backgroundMusic.Pause();
    //        _sampleMusic = GetComponent<AudioSource>();
    //        _sampleMusic.clip = selected;
    //        _sampleMusic.Play();
    //        isPause = true;
    //    }
    //    else
    //    {
    //        _sampleMusic.Stop();
    //        _backgroundMusic.UnPause();
    //        isPause = false;
    //    }
    //}

    public void SetSong(AudioClip selected)
    {
        chosenSong = selected;
    }

    public void TitleMusic(AudioClip title)
    {
        _backgroundMusic.clip = title;
        _backgroundMusic.Play();
    }
}
