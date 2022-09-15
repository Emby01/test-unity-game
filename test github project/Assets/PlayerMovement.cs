using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // Reference to Rigidbody component, called "rb"

    public float forwardForce = 2000f; // Variable for the forward force on the cube
    public float sidewaysForce = 500f; // Same but sideways

    // Use FixedUpdate instead of Update when messing around with physics, apparently
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Adds a forward force on the z-axis

        if(Input.GetKey("d"))
        {
            // Ifs only executed if condition is met
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("a"))
        {
            // Ifs only executed if condition is met
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
