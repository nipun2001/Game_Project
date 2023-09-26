using UnityEngine;

public class DropAndBounce : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dropForce = 1f;
    public float bounceForce = 1f;
    private bool hasBounced = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.down * dropForce); // Drop the ball with initial force
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            // Check if the collision was with the ground or a surface you want to bounce off
            if (collision.gameObject.CompareTag("Player"))
            {
                rb.AddForce(Vector2.up * bounceForce); // Apply an upward force for bounce

            }
            else if (!hasBounced && collision.gameObject.CompareTag("Finish"))
            {
                rb.velocity = new Vector2(rb.velocity.x, 0); // Reset vertical velocity
                rb.AddForce(Vector2.down * bounceForce); // Apply a downward force for bounce
                hasBounced = false; // Mark as not bounced to keep bouncing
                
            }
        
    }
    
}