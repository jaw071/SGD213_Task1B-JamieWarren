using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float maximumSpinSpeed = 200;

    void Start()
    {
        // Set the initial angular velocity randomly within the specified range
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);
    }
}
