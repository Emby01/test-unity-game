using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // Reference to Rigidbody component, called "rb"

    // Use FixedUpdate instead of Update when messing around with physics, apparently
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); // Adds a force of 2000 on the z-axis
    }
}
