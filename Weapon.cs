using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint; //stores a refrence to the empty game object that tells us where the bullets will begin firing
    public int damage = 50; 
    public GameObject bulletPrefab;
   


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // if the player pressed the primary fire button...
        {
            Shoot(); // call the shoot method to fire your weapon
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // spawns a bullet at the  barrel of the rifle;

            /*  RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.right * -1) ;

                 Instantiate(impactEffect, hit.point, UnityEngine.Quaternion.identity); // spawn the impact effect at the the object the player hit.
                 linerenderer.SetPosition(0, firePoint.position);
                 linerenderer.SetPosition(1, hit.point);
                 linerenderer.enabled = true;*/
        }
    }

