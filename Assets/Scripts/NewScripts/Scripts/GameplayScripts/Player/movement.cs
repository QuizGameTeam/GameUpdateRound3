using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // public float moveSpeed = 5;
    // public float maxSpeed = 10;
    // public float acceleration = 2;
    // public float deceleration = 1;

    // private Rigidbody2D rb;
    // private Animator animator;

    // private void Start()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    //     animator = GetComponent<Animator>();
    // }

    // private void Update()
    // {
    //     // Get the current horizontal input
    //     float horizontalInput = Input.GetAxis("Horizontal");

    //     // Accelerate the player
    //     rb.AddForce(new Vector2(horizontalInput * acceleration, 0));

    //     // Limit the player's speed to the maximum speed
    //     if (rb.velocity.x > maxSpeed)
    //     {
    //         rb.velocity.x = maxSpeed;
    //     }

    //     // Slow down the player after releasing the button
    //     if (horizontalInput == 0 && rb.velocity.x > 0)
    //     {
    //         rb.velocity.x -= deceleration;
    //     }

    //     // Update the animation
    //     animator.SetFloat("MoveX", rb.velocity.x);
    // }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     // If the player collides with a wall, stop them moving
    //     if (collision.gameObject.tag == "Wall")
    //     {
    //         rb.velocity.x = 0;
    //     }
    // }
}
