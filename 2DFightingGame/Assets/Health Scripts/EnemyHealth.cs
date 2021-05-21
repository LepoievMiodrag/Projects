using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;
    public GameObject deathEffect;
    public Points pts;
    public EnemyRespawn er;
    public EnemyCounter ec;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Healthbar.heal -= damage;
      
        if(health<=0f)
        {
            pts.AddScore();
            Die();
            SoundManager.PlaySound("kill");
        }

    }

    void Die()
    {      
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
        ec.count -= 1;
        er.Death();
    }
}
