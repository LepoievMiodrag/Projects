using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearRain : MonoBehaviour
{
    public Spears spear;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            spear.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            SoundManager.PlaySound("spear");
        }
    }
}
