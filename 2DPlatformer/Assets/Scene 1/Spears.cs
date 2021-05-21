using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spears : MonoBehaviour
{
    public float speed = 100f;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().mass = 1000;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 20;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Player")
        {
            PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.TakeDamage(damage);
            }
            gameObject.SetActive(false);
        }
    }

}
