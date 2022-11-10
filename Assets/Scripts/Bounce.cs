using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    Vector3 velocityval;
    float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        velocityval = rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        speed = velocityval.magnitude;
        var direction = Vector3.Reflect(velocityval.normalized, col.contacts[0].normal);

        rb.velocity = (direction) * Mathf.Max(speed, 2f);
    }
}