using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{

    public GameObject button1;
    public GameObject button2;
    public GameObject text;
    public GameObject rope;

    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            button1.SetActive(true);
            button2.SetActive(true);
            text.SetActive(true);
            rope.SetActive(false);
        }
    }
}
