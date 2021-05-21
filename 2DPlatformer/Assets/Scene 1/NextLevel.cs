using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (collision.tag == "Player")
            {
                SceneManager.LoadScene(2);
            }
        }
        else if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (collision.tag == "Player")
            {
                SceneManager.LoadScene(4);
            }
        }
    }

}
