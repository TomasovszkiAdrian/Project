using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefarb;
    public float attackcooldown;
    private float cooldownTimer;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > cooldownTimer)
        {
            Shoot();
            cooldownTimer = Time.time + attackcooldown;
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefarb, firePoint.position, firePoint.rotation);
        
        
        //Shooting logic
    }
}

