
// MOVEMENT OF PLAYER

using UnityEngine;
using System.IO;
using System;

public class movement : MonoBehaviour
{

    

    [SerializeField] float Speed = 6;
    [SerializeField] float Accel = 2;
    [SerializeField] float gravity = 2;

    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] bool grounded = false;
    [SerializeField] float jumpForce = 2;
    // public float groundCheckDistance;
    // private float bufferCheckDistance = 0.1f;

    void Awake()
    {
        
        // Different characters with different characteristics
        if (gameObject.name == "Jumper")
        {
            // Jump higher
            Speed = 6;
            Accel = 2;
            gravity = 7;
            jumpForce = 6;
        }
        else if (gameObject.name == "Runner")
        {
            // Run faster
            Speed = 10;
            Accel = 5;
            gravity = 3;
            jumpForce = 3;
        }
        else if (gameObject.name == "Flyer")
        {
            // Lower gravity
            Speed = 4;
            Accel = 2;
            gravity = 1;
            jumpForce = 2;
        }

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        rb.gravityScale = gravity;

        // Horizontal movement
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("Speed", Math.Abs(horizontalInput));
        if (horizontalInput != 0)
        {
            if (rb.velocity.x > -Speed && rb.velocity.x < Speed)
            {
                rb.AddForce(new Vector2(horizontalInput * Accel, 0f));
            }
            else 
            {
                rb.velocity = new Vector2(Speed * horizontalInput, rb.velocity.y);
            }
            gameObject.transform.localScale = new Vector3(horizontalInput,1,1);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Jump method
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
        anim.SetBool("IsJumping", !grounded);

        // groundCheckDistance = (GetComponent<CapsuleCollider2D>().size.y/2) + bufferCheckDistance;
        // RaycastHit hit;
        // if (Physics.Raycast(transform.position, -transform.up, out hit, groundCheckDistance))
        // {
        //     grounded = true;
        // }
        // else
        // {
        //     grounded = false;
        // }
    }

    // Check collision
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}