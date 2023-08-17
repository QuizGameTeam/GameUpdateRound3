using UnityEngine;

public class jumping : MonoBehaviour
{
    public bool grounded = false;
    public float jumpForce = 10;
    // public float groundCheckDistance;
    // private float bufferCheckDistance = 0.1f;

    // Update is called once per frame
    void Update()
    {
        // groundCheckDistance = (GetComponent<CapsuleCollider2D>().size.y/2) + bufferCheckDistance;
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
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
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        grounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision) 
    {
        grounded = false;
    }
}