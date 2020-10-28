using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpPower = 7f;
    public Transform target;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpPower;
                rb.velocity = velocity;
                // Debug.Log(velocity);
            }
        }
    }

    // Delete Platform if past camera screen

    void LateUpdate()
    {
        if (target.position.y - transform.position.y > 2)
        {
            Debug.Log("hi");
            Destroy(gameObject);
        }
    }
}
