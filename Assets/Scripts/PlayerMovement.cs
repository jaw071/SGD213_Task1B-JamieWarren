using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Exposes this value to the Editor, but not to other Scripts (pseudo public)
    [SerializeField] private float horizontalPlayerAcceleration = 5000f;
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        // Get the Rigidbody2D component once at the start of the game and store a reference to it
        // This avoids calling GetComponent multiple times (which is slow)
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from the player (left or right arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0.0f)
        {
            // Calculate the force to apply based on input and acceleration
            Vector2 forceToAdd = Vector2.right * horizontalInput * horizontalPlayerAcceleration * Time.deltaTime;
            ourRigidbody.AddForce(forceToAdd);

            // Uncomment the line below for debugging purposes
            // print(horizontalInput);
        }
    }
}
