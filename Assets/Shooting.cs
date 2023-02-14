using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    bool atkCool=false;
    float atkCooltime = 0.5f;

    void Update()
    {
        if (Input.GetMouseButton(0) && atkCool == false)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.right * bulletForce, ForceMode2D.Impulse);

        atkCool = true;
        StartCoroutine("atkCoolTime");
    }

    private IEnumerator atkCoolTime()
    {
        yield return new WaitForSeconds(atkCooltime);
        atkCool = false;
    }

}
