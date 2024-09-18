using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public AudioClip bgmusic; // Public reference to the attack sound clip

    private AudioSource audioSource;

    void Start()
    {
        Invoke("PlaySFX", 4);
    }

    public void PlaySFX()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // Start playing the loop

    }
}
