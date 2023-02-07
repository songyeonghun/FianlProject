using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulllet2 : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 LastVelocity;
    Vector2 player;

    private void Start()
    {
        rb.velocity = player;
    }

    void Update()
    {
        LastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = LastVelocity.magnitude;
        var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 10f);
    }

}
