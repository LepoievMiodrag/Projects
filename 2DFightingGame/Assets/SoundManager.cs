using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip  Grapple, Shoot, GetHit, Die, Kill, Heal;

    static AudioSource audioSrc;

    void Start()
    {
        Grapple = Resources.Load<AudioClip>("grapple");
        Shoot = Resources.Load<AudioClip>("shoot");
        GetHit = Resources.Load<AudioClip>("gethit");
        Kill = Resources.Load<AudioClip>("kill");
        Heal = Resources.Load<AudioClip>("heal");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "grapple":
                audioSrc.PlayOneShot(Grapple);
                    break;
            case "shoot":
                audioSrc.PlayOneShot(Shoot);
                break;
            case "gethit":
                audioSrc.PlayOneShot(GetHit);
                break;
            case "kill":
                audioSrc.PlayOneShot(Kill);
                break;
            case "heal":
                audioSrc.PlayOneShot(Heal);
                break;
        }
    }

}
