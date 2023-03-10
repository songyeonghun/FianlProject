using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerState : MonoBehaviour
{
    static public int statHp;
    static public int statAtk;
    static public int statMoveSpeed;
    static public int statAtkSpeed;
    static public int statHpUse;
    static public float StatHpRegen;

    public Text HPText;

    //스탯표
    public int[][] stat = new int[6][]
    {
        new int[]{ 300,320,340,360,380,400,420,440,460,480,500},    //0 채력
        new int[]{ 100,110,120,130,140,150},                            //1 공격력
        new int[]{ 10,11,12},                                              //2 이동속도
        new int[]{ 10,11,12,13,14,15},                                    //3 공격속도
        new int[]{ 3,2},                                                    //4 채력소모
        new int[]{ 30,40,50}                                               //5 채력회복
    };

    void Start()
    {
        statHp = PlayerPrefs.GetInt("statHP");
        statAtk = PlayerPrefs.GetInt("statAtk");
        statMoveSpeed = PlayerPrefs.GetInt("statMoveSpeed");
        statAtkSpeed = PlayerPrefs.GetInt("statAtkSpeed");
        StatHpRegen = PlayerPrefs.GetInt("StatHpRegen");
        statHpUse = PlayerPrefs.GetInt("statHpUse");

        HPText.text = "Level: " + statHp + "\nHP: " + stat[0][statHp];
    }

    public void HpUp()
    {
        if (statHp < 10)
        statHp++;
        HPText.text = "Level: "+ statHp + "\nHP: " + stat[0][statHp];
        PlayerPrefs.SetInt("statHP", statHp);

        Debug.Log(statHp);
    }
    public void AtkUp()
    {
        if (statAtk < 5)
            statAtk++;
    }
    public void MoveSpeedUp()
    {
        if(statMoveSpeed<3)
        statMoveSpeed++;
    }
    public void AtkSpeedUp()
    {
        if(statAtkSpeed<5)
        statAtkSpeed++;
    }
    public void HpRegenUp()
    {
        if(StatHpRegen<2)
        StatHpRegen++;
    }
    public void HpUseUp()
    {
        if(statHpUse<3)
        statHpUse++;
    }
}
