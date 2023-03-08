using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    static public int statHp;
    static public int statAtk;
    static public int statMoveSpeed;
    static public int statAtkSpeed;
    static public int StatHpRegen;
    static public int statHpUse;


    void Start()
    {
        statHp = PlayerPrefs.GetInt("StatHP");
        statAtk = PlayerPrefs.GetInt("statAtk");
        statMoveSpeed = PlayerPrefs.GetInt("statMoveSpeed");
        statAtkSpeed = PlayerPrefs.GetInt("statAtkSpeed");
        StatHpRegen = PlayerPrefs.GetInt("StatHpRegen");
        statHpUse = PlayerPrefs.GetInt("statHpUse");
    }

    void Update()
    {
        
    }
}
