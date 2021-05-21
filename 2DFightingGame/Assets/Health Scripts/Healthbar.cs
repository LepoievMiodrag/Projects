using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public EnemyHealth enemyhealth;
    Image healthImage;
    float maxHealth = 100f;
    public static float heal;


    void Update()
    {
        healthImage = GetComponent<Image>();
        heal = enemyhealth.health;  
        healthImage.fillAmount = heal / maxHealth;
    }
}
