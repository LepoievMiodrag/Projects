using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public PlayerHealth ph;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -100000 * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Player")
        {
            ph.GetComponent<Rigidbody2D>().velocity = new Vector2(100,-1 * ph.GetComponent<Rigidbody2D>().velocity.y);
            ph.GetComponent<Rigidbody2D>().velocity = new Vector2(60, -1 * ph.GetComponent<Rigidbody2D>().velocity.x);
            SoundManager.PlaySound("saw");
            ph.TakeDamage(2);
        }


    }

}
