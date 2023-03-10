using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    //플레이어 스탯
    int Hp;
    int MaxHp;
    int MoveSpeed = PlayerState.stat[2][PlayerState.statMoveSpeed];  

    //대쉬
    bool canDash = true;
    bool isDashing = false;
    int DashSpeed = 2;
    float DashTime=0.2f;
    float dashCoolTime = 0.5f;

    //마우스
    public Camera cam;
    static public Vector2 len;
    Vector2 movement;
    Vector2 mousepos;

    void Update()
    {
        //플레이어 회전을 위한 마우스 좌표값 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(1)&& canDash==true)
           StartCoroutine(Dash());

    }
    void FixedUpdate()
    {
        //rb를 이용한 물리적 플레이어 이동
        rb.MovePosition(rb.position + movement * (MoveSpeed/DashSpeed) * Time.fixedDeltaTime);

        //마우스 위치에 따른 플레이어 회전
        Vector2 lookdir = mousepos - rb.position;
        float angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }


    //대쉬와 쿨타임
    private IEnumerator Dash()
    {
        Debug.Log("dash");
        canDash = false;
        DashSpeed = 1;
        //대쉬시 무적코드 넣을자리
        yield return new WaitForSeconds(DashTime);
        DashSpeed = 2;
        yield return new WaitForSeconds(dashCoolTime);
        canDash = true;
    }

    /*
    SpriteRenderer spriteRenderer;
    Animator anim;
    float flip;

    private bool canDash = true;
    private bool isDashing;
    private float move = 1f;

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

    */
}
