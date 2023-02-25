using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GameSave()
    {
        PlayerPrefs.SetInt("StatHP",PlayerHP.StatHp);
    }
    public void GameLoad()
    {
        PlayerHP.StatHp = PlayerPrefs.GetInt("StatHP");
    }
}
