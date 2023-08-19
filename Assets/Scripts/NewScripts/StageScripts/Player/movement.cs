
// MOVEMENT OF PLAYER

using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UI;

public class movement : MonoBehaviour
{
    [SerializeField] float Speed = 6;
    [SerializeField] float Accel = 2;
    [SerializeField] float gravity = 2;

    private float border = -100;

    private Rigidbody2D rb;
    private Animator anim;
    private HeartCount HeartCount;
    private GameplayScripts GameplayScripts;

    [SerializeField] bool grounded = false;
    [SerializeField] float jumpForce = 2;

    public Vector2 respawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        HeartCount = FindObjectOfType<HeartCount>();
        GameplayScripts = FindObjectOfType<GameplayScripts>();

    }
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
        // Respawn if falling
        // if (transform.position.y < border)
        // {
        //     RespawnNow();
        // }
    }

    // public void RespawnNow() 
    // {
    //     transform.position = respawnPoint;
    //     HeartCount.TakeDamage(1);
    // }

    // Check collision
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        // Ground check enter
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Reset checkpoint
        if (collision.gameObject.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }
        if (collision.gameObject.name == "Endpoint")
        {
            GameplayScripts.GameOver_State();
            GameplayScripts.Pause();
        }
        if (collision.gameObject.name == "Chall")
        {
            GameplayScripts.Explain_StateChall();
            //GameplayScripts.Pause();
        }
        if (collision.gameObject.name == "ques")
        {
            GameplayScripts.Ask_State();
            //GameplayScripts.Pause();
        }
        
        // Respawn if touch enemy
        // if (collision.gameObject.tag == "Enemy")
        // {
        //     RespawnNow();
        // }
    }
    private void OnCollisionExit2D(Collision2D collision) 
    {
        // Ground check exit
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}