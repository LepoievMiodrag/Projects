using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        Movement mv = hitInfo.GetComponent<Movement>();
        if (hitInfo.tag == "Player")
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x, 300);
        }

    }

}
