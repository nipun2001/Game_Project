using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float bounceForce = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Apply an initial force to make the ball bounce
        rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Bounce the ball when it collides with something
        rb.velocity = new Vector2(rb.velocity.x, bounceForce);
    }
}