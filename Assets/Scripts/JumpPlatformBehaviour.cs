using UnityEngine;

public class JumpPlatformBehaviour : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.AddForce(Vector2.up * Speed, ForceMode2D.Impulse);
        }
    }
}
