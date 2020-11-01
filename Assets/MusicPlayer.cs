using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioClip song;

    private bool isPlaying;


    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();

        isPlaying = true;

        if (isPlaying)
        {
            audioPlayer.PlayOneShot(song);
        }
    }
}
