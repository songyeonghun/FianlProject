using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Slider hpbar;
    public static int StatHp=100;
    public float maxHp;
    public float currentHp;

    void Start()
    {
        
    }


    void Update()
    {
        hpbar.value = currentHp / maxHp;
    }
}
