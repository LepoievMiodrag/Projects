using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneShooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Shoot", 1f, 3f);
    }

    void Shoot()
    {
        // shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
