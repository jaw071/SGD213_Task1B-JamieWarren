using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour {

    private float acceleration = 50f;
    private float initialVelocity = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        // Get Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();

        // Set initial velocity
        rb.velocity = Vector2.up * initialVelocity;
    }

    void Update()
    {
        // Calculate and add force
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
        rb.AddForce(ForceToAdd);
    }
}
