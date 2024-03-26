using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement PlayerMovement;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the player (left or right arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0.0f)
        {
            PlayerMovement.HorizontalMovement(horizontalInput);
        }
    }
}
