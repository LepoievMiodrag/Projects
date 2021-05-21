using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearActivation : MonoBehaviour
{
    public Spears sp;
    public Spears sp2;
    public Spears sp3;
    public Spears sp4;
    public Spears sp5;
    public Spears sp6;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        sp.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        sp2.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        sp3.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        sp4.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        sp5.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        sp6.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        gameObject.SetActive(false);
    }
}
