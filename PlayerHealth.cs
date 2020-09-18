using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100; // an interger storing the health amount
   // public GameObject player;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
        void Die()
        {
            Destroy(this.gameObject); // destroy the player game object


        }
    }
}
    
