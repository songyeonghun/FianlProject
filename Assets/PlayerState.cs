using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerState : MonoBehaviour
{
    //������ ����
    static public int statHp;
    static public int statAtk;
    static public int statMoveSpeed;
    static public int statAtkSpeed;
    static public int statHpUse;
    static public int StatHpRegen;

    //�������
    public Text HPText;
    public Text AtkText;
    public Text MoveSpeedText;
    public Text AtkSpeedText;
    public Text HPUseText;
    public Text HPRegenText;


    //����ǥ
    public int[][] stat = new int[6][]
    {
        new int[]{ 300,320,340,360,380,400,420,440,460,480,500},    //0 ä��
        new int[]{ 100,110,120,130,140,150},                            //1 ���ݷ�
        new int[]{ 10,11,12},                                              //2 �̵��ӵ�
        new int[]{ 10,11,12,13,14,15},                                    //3 ���ݼӵ�
        new int[]{ 3,2},                                                    //4 ä�¼Ҹ�
        new int[]{ 30,40,50}                                               //5 ä��ȸ��
    };

    void Start()
    {
        //������ ������ �ҷ�����
        statHp = PlayerPrefs.GetInt("statHP");
        statAtk = PlayerPrefs.GetInt("statAtk");
        statMoveSpeed = PlayerPrefs.GetInt("statMoveSpeed");
        statAtkSpeed = PlayerPrefs.GetInt("statAtkSpeed");
        statHpUse = PlayerPrefs.GetInt("statHpUse");
        StatHpRegen = PlayerPrefs.GetInt("StatHpRegen");


        //����â�� ����� ���� ǥ��
        HPText.text = "Level: " + statHp + "\nHP: " + stat[0][statHp];
        AtkText.text = "Level: " + statAtk + "\nATK: " + stat[1][statAtk];
        MoveSpeedText.text = "Level: " + statMoveSpeed + "\nMoveSpeed: " + stat[2][statMoveSpeed];
        AtkSpeedText.text = "Level: " + statAtkSpeed + "\nAtkSpeed: " + stat[3][statAtkSpeed];
        HPUseText.text = "Level: " + statHpUse + "\nHpUse: " + stat[4][statHpUse];
        HPRegenText.text = "Level: " + StatHpRegen + "\nHpRegen: " + stat[5][StatHpRegen];

    }


    //���Ⱦ�
    public void HpUp()
    {
        if (statHp < 10)
        statHp++;
        HPText.text = "Level: "+ statHp + "\nHP: " + stat[0][statHp];
        PlayerPrefs.SetInt("statHp", statHp);

        Debug.Log(statHp);
    }
    public void AtkUp()
    {
        if (statAtk < 5)
            statAtk++;
        AtkText.text = "Level: " + statAtk + "\nATK: " + stat[1][statAtk];
        PlayerPrefs.SetInt("statAtk", statAtk);

        Debug.Log(statAtk);
    }
    public void MoveSpeedUp()
    {
        if(statMoveSpeed<2)
        statMoveSpeed++;
        MoveSpeedText.text = "Level: " + statMoveSpeed + "\nMoveSpeed: " + stat[2][statMoveSpeed];
        PlayerPrefs.SetInt("statMoveSpeed", statMoveSpeed);

        Debug.Log(statMoveSpeed);
    }
    public void AtkSpeedUp()
    {
        if(statAtkSpeed<5)
        statAtkSpeed++;
        AtkSpeedText.text = "Level: " + statAtkSpeed + "\nAtkSpeed: " + stat[3][statAtkSpeed];
        PlayerPrefs.SetInt("statAtkSpeed", statAtkSpeed);

        Debug.Log(statAtkSpeed);
    }
    public void HpUseUp()
    {
        if (statHpUse < 1)
            statHpUse++;
        HPUseText.text = "Level: " + statHpUse + "\nHpUse: " + stat[4][statHpUse];
        PlayerPrefs.SetInt("statHpUse", statHpUse);

        Debug.Log(statHpUse);
    }
    public void HpRegenUp()
    {
        if(StatHpRegen<2)
        StatHpRegen++;
        HPRegenText.text = "Level: " + StatHpRegen + "\nHpRegen: " + stat[5][StatHpRegen];
        PlayerPrefs.SetInt("StatHpRegen", StatHpRegen);

        Debug.Log(StatHpRegen);
    }

}
