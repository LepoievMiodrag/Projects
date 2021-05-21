using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthNumber : MonoBehaviour
{
    public PlayerHealth plh;
    public Text txt;

    void Update()
    {
        txt = GetComponent<Text>();
        txt.text = plh.health.ToString();
    }
}
