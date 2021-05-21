using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth ph;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(ph != null && ph.health <10)
        {
            ph.Heal(2);
            gameObject.SetActive(false);
            SoundManager.PlaySound("heal");
        }
    }
}
