using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalZombieHeath : MonoBehaviour
{
    public int health = 100;
    public GameObject Zombie;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health == 0)
        {
            Die();
        }
        void Die()
        {
            Destroy(Zombie);
           
        }
    }
}