using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static AudioClip Music;

    static AudioSource audioSrc;

    void Start()
    {
        Music = Resources.Load<AudioClip>("music");
        
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "music":
                audioSrc.PlayOneShot(Music);
                break;
        }
    }
}
