using System.Security.Cryptography;
using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class BirdMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 movement;
    public float speed = 5f;
    public float yForce = 20f;
    void Update()
    {
    }
    void FixedUpdate()
    {
        rb.linearVelocityX = movement.x * speed;
        if (Input.GetKey("space"))
        {
            rb.linearVelocity = Vector2.zero; // Reset vertical velocity before applying new force
            rb.AddForce(Vector2.up * yForce, ForceMode2D.Impulse);
        }
    }
}
