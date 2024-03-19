using UnityEngine;

public class EnemyMoveForward : MonoBehaviour 
{
    private float acceleration = 75f;
    private float initialVelocity = 2f;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Set the initial velocity of the enemy
        rb.velocity = Vector2.down * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // Apply force to the enemy based on acceleration and time
        Vector2 forceToAdd = Vector2.down * acceleration * Time.deltaTime;
        rb.AddForce(forceToAdd);
    }
}
