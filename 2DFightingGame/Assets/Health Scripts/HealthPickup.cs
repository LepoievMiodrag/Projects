using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    private float value = 20f;
    public HealthCounter hc;
    public HealthPackRespawn hpr;
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.tag == "Torso")
        {
            PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
            if (player.health != 100f)
            {
                player.HealPlayer(value);
                SoundManager.PlaySound("heal");
                gameObject.SetActive(false);
                hc.count -= 1;
                hpr.Resp();
            }
            
        }
        

    }
}
