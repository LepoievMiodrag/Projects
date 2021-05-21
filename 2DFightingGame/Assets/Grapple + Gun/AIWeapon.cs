using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Shoot", 1f, 2f);
    }

    void Shoot()
    {
        // shooting logic
        if (transform.gameObject.activeInHierarchy == true) 
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            EnemyShotSounds.PlaySound("enemyfire");
        }
    }
}
