using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotSounds : MonoBehaviour
{
    public static AudioClip EnemyFire;

    static AudioSource audioSrc;

    void Start()
    {
        EnemyFire = Resources.Load<AudioClip>("enemyfire");
        

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "enemyfire":
                audioSrc.PlayOneShot(EnemyFire);
                break;
            
        }
    }
}
