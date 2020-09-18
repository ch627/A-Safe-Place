using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalZombieAttack : MonoBehaviour
{
    public int normalZombieDamage = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth player = collision.GetComponent<PlayerHealth>(); // try to find a player health script on the object the zombie with
        player.TakeDamage(normalZombieDamage);


);
    }
}
