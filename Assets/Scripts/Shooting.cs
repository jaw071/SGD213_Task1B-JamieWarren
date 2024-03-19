using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet; // Reference to the bullet prefab

    private float lastFiredTime = 0f; // Time when the last shot was fired

    [SerializeField]
    private float fireDelay = 1f; // Delay between shots (in seconds)

    private float bulletOffset = 2f; // Offset for spawning bullets

    void Start()
    {
        // Calculate the bullet offset for spawning
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2
            + bullet.GetComponent<Renderer>().bounds.size.y / 2;
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            float currentTime = Time.time;

            // Add a delay to prevent rapid firing
            if (currentTime - lastFiredTime > fireDelay)
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
                Instantiate(bullet, spawnPosition, transform.rotation);
                lastFiredTime = currentTime;
            }
        }
    }
}
