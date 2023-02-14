using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    private bool canDash = true;
    private bool isDashing;
    private float move = 0.01f;

    public float maxHP = 100;
    public float HP;
    public float moveSpeed = 5f;
    public float dashSpeed;
    public float dashTime = 0.2f;
    public float dashCoolTime = 0.5f;
    public bool atkCoolTime = false;

    static public Vector2 len;

    public Slider hpBar;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousepos;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        HP = maxHP;
    }

    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

       mousepos = cam.ScreenToWorldPoint(Input.mousePosition);

        //총발사 (좌클릭)
        if (Input.GetMouseButton(0))
        {
            if (atkCoolTime == false)
            {
                HP--;
            }
        }

        //체력바
        //hpBar.value = HP / maxHP;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookdir = mousepos - rb.position;
        float angle = Mathf.Atan2(lookdir.y,lookdir.x)*Mathf.Rad2Deg;
        rb.rotation = angle;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //총알 회수시 회복
        if (collision.gameObject.tag == "bullet")
        {
            HP++;
        }
    }

    //대쉬 딜레이
    private IEnumerator dash()
    {
        canDash = false;
        move = dashSpeed;
        yield return new WaitForSeconds(dashTime);
        move = moveSpeed;
        yield return new WaitForSeconds(dashCoolTime);
        canDash = true;
    }
}
