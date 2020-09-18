using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f; // this is the speed the bullet is traveling at
    public Rigidbody2D rb2d; // stores the rigidbody on this game object
    public int damage = 50; // stores the amount of damage the bullets will do
    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = transform.right * -1 * speed; // make the bullet fly forward
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) // store info about the enemy we hit
    {
        NormalZombieHeath zombie = hitInfo.GetComponent<NormalZombieHeath>(); // try to finda health script for a normal zombie on the object we hit
        zombie.TakeDamage(damage); //the zombie takes damage
        
        Destroy(gameObject); // The bullet clone is destroyed
    }
}

