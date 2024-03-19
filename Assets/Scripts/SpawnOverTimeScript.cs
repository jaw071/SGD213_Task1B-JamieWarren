using UnityEngine;

public class SpawnOverTimeScript : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnObject; // Object to spawn

    [SerializeField]
    private float spawnDelay = 2f; // Delay between spawns (in seconds)

    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();

        // Hide the spawner initially
        renderer.enabled = false;

        // Call the Spawn function after spawnDelay seconds, and repeat every spawnDelay seconds
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        // Calculate the x-coordinate range for spawning
        float x1 = transform.position.x - renderer.bounds.size.x / 2;
        float x2 = transform.position.x + renderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
