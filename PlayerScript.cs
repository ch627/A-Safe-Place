using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public  Rigidbody2D rb2d;
    public BoxCollider2D bc2d;
    public float FlipScale;
    // Start is called before the first frame update
    void Start()
    {
        FlipScale = transform.localScale.x * -1; // assuming this is facing left
        rb2d = GetComponent<Rigidbody2D>(); // get the player rigidbody
        bc2d = GetComponent<BoxCollider2D>(); // get the pllayer collider
        transform.localScale = new Vector2(FlipScale, transform.localScale.y);
        transform.localScale = new Vector2(-FlipScale, transform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movment = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movment * Time.deltaTime * MoveSpeed;

    }

      

}
