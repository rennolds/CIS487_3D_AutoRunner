using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMusicHandler : MonoBehaviour
{
    public MusicHandler overallMusic;
    AudioSource _sampleMusic;
    AudioClip title, barreling, cursed;
    bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        _sampleMusic = GetComponent<AudioSource>();
        overallMusic = MusicHandler.instance;
        overallMusic.PauseMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSample(AudioClip selected)
    {
        if (!isPause)
        {
            //overallMusic.PauseMusic();
            _sampleMusic.clip = selected;
            if (_sampleMusic.isPlaying)
                _sampleMusic.Stop();
            _sampleMusic.Play();
            isPause = true;
        }
        else
        {
            _sampleMusic.Stop();
            //overallMusic.UnPauseMusic();
            isPause = false;
        }
    }

    public void SetSong(AudioClip selected)
    {
        overallMusic.SetSong(selected);
    }
}
