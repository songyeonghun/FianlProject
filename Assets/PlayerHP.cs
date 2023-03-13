using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Slider hpbar;
    public float maxHp;
    public float currentHp;

    void Update()
    {
        hpbar.value = currentHp / maxHp;
    }
}
