using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public Movement mv;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && mv.moveSpeed == 30)
        {
            mv.moveSpeed = 150;
        }
        else if (collision.tag == "Player" && mv.moveSpeed == 150)
        {
            mv.moveSpeed = 30;
        }
    }
}
