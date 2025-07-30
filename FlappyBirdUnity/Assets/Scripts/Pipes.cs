using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 pipeMovement;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pipeMovement = new Vector2(-1, 0).normalized;
    }
    void Update()
    {

    }
    void FixedUpdate()
    {
        rb.linearVelocity = pipeMovement * speed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bird"))
        {
            Debug.Log("Collision with Pipe detected!");
            rb.linearVelocity = Vector2.zero;
        }
    }
    
}
