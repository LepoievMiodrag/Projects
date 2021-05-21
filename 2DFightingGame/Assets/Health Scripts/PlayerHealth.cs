using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;
    public GameObject deathEffect;

    public void TakeDamage(float damage)
    {
        health -= damage;
        SoundManager.PlaySound("gethit");

        if (health <= 0f)
        {
            Die();
        }

    }

    public void HealPlayer(float healv)
    {
        health += healv;
    }


    void Die()
    {
        Invoke("ded", 2f);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }

    void ded()
    {
        Application.LoadLevel(3);
        gameObject.SetActive(true);
    }

    void Update()
    {
        if( health > 100f)
        {
            health = 100f;
        }
    }

}
