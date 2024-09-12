using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] musicClips;
    public AudioSource audioSource;
    private int currentClipIndex;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayNextSong();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            PlayNextSong();
        }
    }
    void PlayNextSong()
    {
        if(musicClips.Length == 0) return;
        audioSource.clip = musicClips[currentClipIndex];
        audioSource.Play();
        
        currentClipIndex = (currentClipIndex+1) % musicClips.Length;
    }
}
