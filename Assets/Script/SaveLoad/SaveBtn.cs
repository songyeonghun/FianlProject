using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveBtn : MonoBehaviour
{
    void Start()
    {
        PlayerHP.StatHp = PlayerPrefs.GetInt("StatHP");
    }
}
