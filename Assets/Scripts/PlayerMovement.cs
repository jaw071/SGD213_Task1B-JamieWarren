using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Exposes this value to the Editor, but not to other Scripts (pseudo public)
    public float horizontalPlayerAcceleration = 5000f;
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        // Get the Rigidbody2D component once at the start of the game and store a reference to it
        // This avoids calling GetComponent multiple times (which is slow)
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    public void HorizontalMovement(float horizontalInput)
    {
        // Calculate the force to apply based on input and acceleration
        Vector2 forceToAdd = Vector2.right * horizontalInput * horizontalPlayerAcceleration * Time.deltaTime;
        ourRigidbody.AddForce(forceToAdd);
    }
}
