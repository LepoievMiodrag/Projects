using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDeactivation : MonoBehaviour
{

    public GameObject Block;
    public GameObject grass;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.tag == "Player")
        {
            gameObject.SetActive(false);
            Block.SetActive(false);
            grass.SetActive(false);
        }

    }

}
