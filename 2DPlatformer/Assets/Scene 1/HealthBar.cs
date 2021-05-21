using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth ph;
    public Slider healthslide;
   
    void Update()
    {
        healthslide = GetComponent<Slider>();
        healthslide.value = ph.health;
    }
}
