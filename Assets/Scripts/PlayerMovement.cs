using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float groundDrag;

    public Transform orientation;

    float hInput;
    float vInput;

    Vector3 moveDirection;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; 
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");
        rb.drag = groundDrag;
        VelocityControl();

    }

    void FixedUpdate() {
        moveDirection = orientation.forward * vInput + orientation.right * hInput;
        
        rb.AddForce(moveDirection.normalized * movementSpeed * 10f, ForceMode.Force);
    }

    private void VelocityControl() {
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        if (flatVelocity.magnitude > movementSpeed) {
            Vector3 reducedVelocity = flatVelocity.normalized * movementSpeed;
            rb.velocity = new Vector3(reducedVelocity.x, rb.velocity.y, reducedVelocity.z);
        }
    }
}