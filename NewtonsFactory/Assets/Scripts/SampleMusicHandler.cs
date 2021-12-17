using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMusicHandler : MonoBehaviour
{
    public MusicHandler overallMusic;
    public AudioSource menuSounds;
    AudioSource _sampleMusic;
    public AudioClip menuConfirm, menuBack;

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
        if (selected == _sampleMusic.clip && _sampleMusic.isPlaying)
        {
            menuSounds.PlayOneShot(menuBack);
            _sampleMusic.Stop();
        }
        else
        {
            menuSounds.PlayOneShot(menuConfirm);
            _sampleMusic.clip = selected;
            _sampleMusic.Play();
        }
    }

    public void SetSong(AudioClip selected)
    {
        menuSounds.PlayOneShot(menuConfirm);
        overallMusic.SetSong(selected);
    }
}
