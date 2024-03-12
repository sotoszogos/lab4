using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRigidbody : MonoBehaviour {
    Rigidbody rb;
    float xMove, yMove;
    public float speed = 7;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        //whenever the user presses the fire button
        //the fireVelocity (editable thorugh Unity Editor)
        //is assigned to the rigidbody
        if (Input.GetButton("Fire1"))
        {
            rb.velocity = new Vector3(0, 10, 0);
        }
        xMove = Input.GetAxis("Horizontal");
        yMove = Input.GetAxis("Vertical");

        //can be used as a projectile in Angry Birds-type worlds.
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(xMove * speed, rb.velocity.y, yMove * speed);
    }
}
