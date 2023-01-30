using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyBullet", 10);
    }

    void Update()
    {
        transform.Translate(Vector2.right* 5 *Time.deltaTime);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

}