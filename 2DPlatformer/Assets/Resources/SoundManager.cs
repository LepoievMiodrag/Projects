using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip Lava, Saw, GetHit, Die, Heal, Door, Spear, Jump;

    static AudioSource audioSrc;

    void Start()
    {
        Lava = Resources.Load<AudioClip>("lava");
        Saw = Resources.Load<AudioClip>("saw");
        GetHit = Resources.Load<AudioClip>("gethit");
        Die = Resources.Load<AudioClip>("die");
        Heal = Resources.Load<AudioClip>("heal");
        Door = Resources.Load<AudioClip>("door");
        Spear = Resources.Load<AudioClip>("spear");
        Jump = Resources.Load<AudioClip>("jump");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "gethit":
                audioSrc.PlayOneShot(GetHit);
                break;
            case "lava":
                audioSrc.PlayOneShot(Lava);
                break;
            case "saw":
                audioSrc.PlayOneShot(Saw);
                break;
            case "die":
                audioSrc.PlayOneShot(Die);
                break;
            case "heal":
                audioSrc.PlayOneShot(Heal);
                break;
            case "door":
                audioSrc.PlayOneShot(Door);
                break;
            case "spear":
                audioSrc.PlayOneShot(Spear);
                break;
            case "jump":
                audioSrc.PlayOneShot(Jump);
                break;
        }
    }

}
