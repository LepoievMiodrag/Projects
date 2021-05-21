using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamage : MonoBehaviour
{
    public int damage;
    public int jumpHeight;

    void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth player = collision.GetComponent<PlayerHealth>();
        if(player != null)
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            player.TakeDamage(damage);
            SoundManager.PlaySound("lava");
        }
    }
}
