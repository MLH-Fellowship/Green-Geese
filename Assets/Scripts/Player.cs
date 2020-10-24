using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is so there will always be the RigidBody 2D Component in the inspector
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    public float movementSpeed = 8f;

    // Assigning rb as Rigidbody2D component 
    Rigidbody2D rb;

    float movement = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // For side-to-side movement of character
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}