using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float MoveSpeed = 5f; // determines the speed the player will moves at, by default, this is 5.
    public  Rigidbody2D rb2d; // stores the Rigidbody 2D
    public BoxCollider2D bc2d; // stores the BoxCollider 2D
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // get the player rigidbody
        bc2d = GetComponent<BoxCollider2D>(); // get the pllayer collider
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movment = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movment * Time.deltaTime * MoveSpeed;

    }

      

}
