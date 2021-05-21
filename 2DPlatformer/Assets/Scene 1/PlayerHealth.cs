using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;

    void Start()
    {
        health = 10;   
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        SoundManager.PlaySound("gethit");
        if (health <= 0)
        {
            SoundManager.PlaySound("die");
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(3);
    }

    public void Heal(int hp)
    {
        health += hp;
    }

    void Update()
    {
        if(health > 10)
        {
            health = 10;
        }
    }
}
