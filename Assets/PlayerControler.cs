using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator anim;
    float flip;

    private bool canDash = true;
    private bool isDashing;
    private float move = 0.01f;

    public float maxHP = 100;
    public float HP;
    public float moveSpeed = 5f;
    public float dashSpeed;
    public float dashTime = 0.2f;
    public float dashCoolTime = 0.5f;

    static public Vector2 len;

    public Slider hpBar;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousepos;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim=GetComponent<Animator>();
    }
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

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("move", true);
        }

        //체력바
        hpBar.value = HP / maxHP;
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
