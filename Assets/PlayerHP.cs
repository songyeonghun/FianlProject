using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Slider hpbar;
    public static int StatHp;
    public float maxHp;
    public float currentHp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpbar.value = currentHp / maxHp;
    }
}
