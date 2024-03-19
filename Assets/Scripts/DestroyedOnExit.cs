using UnityEngine;

public class DestroyedOnExit : MonoBehaviour
{
    // Function that is called when the game object is no longer visible
    void OnBecameInvisible()
    {
        // Destroy the game object when it leaves the viewport
        Destroy(gameObject);
    }
}