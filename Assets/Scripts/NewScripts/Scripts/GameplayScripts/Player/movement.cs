
// MOVEMENT OF PLAYER

using UnityEngine;

public class movement : MonoBehaviour
{
    public float Speed = 10;
    public float gravity = 10;

    private Rigidbody2D rb;
    private Animator animator;

    public bool grounded = false;
    public float jumpForce = 10;
    // public float groundCheckDistance;
    // private float bufferCheckDistance = 0.1f;

    void Start()
    {
        // Difference character ability
        if (gameObject.name == "Jumper")
        {
            // Jump higher
            Speed = 10;
            gravity = 10;
            jumpForce = 10;
        }
        else if (gameObject.name == "Runner")
        {
            // Run faster
            Speed = 10;
            gravity = 10;
            jumpForce = 10;
        }
        else if (gameObject.name == "Flyer")
        {
            // Lower gravity
            Speed = 10;
            gravity = 10;
            jumpForce = 10;
        }

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        rb.gravityScale = gravity;

        // Horizontal movement
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput != 0)
        {
            rb.AddForce(new Vector2(horizontalInput * Speed, 0f));
            gameObject.transform.localScale = new Vector3(horizontalInput,1,1);
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
        grounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision) 
    {
        grounded = false;
    }
}
