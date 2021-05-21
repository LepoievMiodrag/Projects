using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBullets : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public float damage = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

        Invoke("Dest", 50f);
    }

    void Dest()
    {
        Destroy(gameObject);
    }

    

}