using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthbar : MonoBehaviour
{
    public PlayerHealth ph;
    public Slider healthslide;
    float maxHealth = 100f;
    public static float heal;


    void Update()
    {
        healthslide = GetComponent<Slider>();
        heal = ph.health;
        healthslide.value = heal / maxHealth;
    }
}
