using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 dir;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Invoke("DestroyBullet", 10);
    }

    void Update()
    {
        dir = rb.velocity;
        transform.Translate(Vector2.right* 5 *Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }

        Vector2 _wallNormal = collision.contacts[0].normal;
        dir = Vector2.Reflect(rb.velocity, _wallNormal).normalized;

        rb.velocity = dir * 1;
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

}