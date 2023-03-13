using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Slider hpbar;
    public float maxHp;
    public float currentHp;

    //플레이어의 소지 열쇠
    int key=0;
    void Update()
    {
        hpbar.value = currentHp / maxHp;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            key++;
            Debug.Log(key);
        }
        else if (collision.gameObject.tag == "StatCoin")
        {
            GameManager.StatCoin++;

            Debug.Log(GameManager.StatCoin);
        }
    }

}
